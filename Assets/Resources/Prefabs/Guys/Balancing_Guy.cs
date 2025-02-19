using UnityEngine;

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
    bool isDropping = false;
    bool hasDropped = false; // might remove this later, kind of a double check but might be useful

    public bool isPredefined = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (isPredefined)
        {
            return;
        } else {
            LoadSprite();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadSprite()
    {
        // Construct the path to the sprite inside the Resources folder
        string path = "Sprites/" + spritePrefix + "_guys/" + spritePrefix + "_guy" + guyCount;

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
}