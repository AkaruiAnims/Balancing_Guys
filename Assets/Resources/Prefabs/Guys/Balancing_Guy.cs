using UnityEngine;
using TMPro;
using UnityEditor.Callbacks;
public class Balancing_Guy : MonoBehaviour
{
    // might change these to gameobjects later to move the connectors around and get on collision events
    public Vector2 Left_Connector;
    public Vector2 Right_Connector;
    public Vector2 Bottom_Connector;
    public Vector2 Top_Connector;

    public bool Left_Connector_Enabled;
    public bool Right_Connector_Enabled;
    public bool Top_Connector_Enabled;

    public string spritePrefix;
    public int guyCount;
    bool hasDropped = false; // might remove this later, kind of a double check but might be useful
    public TextMeshProUGUI scoreCount; 

    public AudioSource audioData;

    public bool isPredefined = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (isPredefined)
        {
            return;
        } else {
            LoadSprite();
            scoreCount = GameObject.Find("Count").GetComponent<TextMeshProUGUI>();
            audioData = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {   
        if (transform.position.y < -1.8 && !hasDropped) 
        {
            hasDropped = true;
            updateScore(true);
            Debug.Log("Dropped " + scoreCount.text);
        }

        if (transform.position.y < -6)
        {
            updateScore();
        }

    }

    void LoadSprite()
    {
        // Construct the path to the sprite inside the Resources folder
        string path = "Sprites/" + spritePrefix + "_guys/" + spritePrefix + "_guy" + (Random.Range(1,guyCount+1));

        // Load the sprite using Resources.Load
        Sprite sprite = Resources.Load<Sprite>(path);

        if (sprite != null)
        {
            // Assign the loaded sprite to the SpriteRenderer
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprite;
        }
        else
        {
            Debug.LogError("Sprite not found at path: " + path);
        }
    }

    void updateScore(bool bump = false)
    {
        if ( bump == true){
            int score = int.Parse(scoreCount.text);
            score++;
            scoreCount.text = score.ToString();
            audioData.Play(0);
        }
        else
        {
            int score = int.Parse(scoreCount.text);
            score--;
            scoreCount.text = score.ToString();
        }
    }
}