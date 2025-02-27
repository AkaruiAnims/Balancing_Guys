using UnityEngine;
using UnityEngine.Windows.WebCam;

public class camZone : MonoBehaviour
{

    public GameObject cam;
    float collisionTime;
    float sinceLastExit;
    bool startMoving;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collisionTime > sinceLastExit){
            if (sinceLastExit+2 < collisionTime) startMoving = true;
            
            if (startMoving){
                cam.transform.position = new Vector2(0,cam.transform.position.y+1);
                transform.position = new Vector2(0,transform.position.y+1);
            }

        } else {
            if (startMoving) startMoving = false;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        collisionTime = Time.time;      
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        sinceLastExit = Time.time;
    }
}
