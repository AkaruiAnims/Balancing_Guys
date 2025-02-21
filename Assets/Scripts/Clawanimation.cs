using UnityEngine;

public class Clawanimation : MonoBehaviour
{
    public Animator animator;
    public BoxCollider2D floor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("SpacePressed", true); 
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("SpacePressed", false);
        }
        

        void removefloor()
        {
            floor.enabled = false;
        }

        void addfloor()
        {
            floor.enabled = true;
        }
    }
}
