using UnityEngine;
using UnityEngine.Windows.WebCam;

public class camZone : MonoBehaviour
{

    public GameObject cam;
    public GameObject CraneFather;
    public GameObject Dropper;
    public GameObject Text;
    float collisionTime;
    float sinceLastExit;
    bool startMoving;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("cam start pos: "+cam.transform.position.y);        
    }

    // Update is called once per frame
    void Update()
    {
        if (collisionTime > sinceLastExit){
            if (sinceLastExit+2 < collisionTime) startMoving = true;
            
            if (startMoving){
                // cam.transform.position = new Vector2(0,cam.transform.position.y-1);
                cam.transform.Translate(new Vector3(0,1,0) * Time.deltaTime);
                transform.Translate(new Vector3(0,1,0) * Time.deltaTime );
                CraneFather.transform.Translate(new Vector3(0,1,0) * Time.deltaTime );
                Dropper.transform.Translate(new Vector3(0,1,0) * Time.deltaTime );
                Text.transform.Translate(new Vector3(0,1,0) * Time.deltaTime);
                Debug.Log("camera new pos: "+cam.transform.position.y);
            }

        } else {
            if (startMoving) startMoving = false;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        collisionTime = Time.time;      
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        collisionTime = Time.time;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        sinceLastExit = Time.time;
    }
}
