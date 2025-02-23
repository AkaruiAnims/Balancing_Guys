using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //load the Game_level scene
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game_level");
        } 
    }

    public void MoveToScene()
    {
        //load the Game_level scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game_level");
    }
}
