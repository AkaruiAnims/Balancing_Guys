using System;
using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class Clawanimation : MonoBehaviour
{
    public Animator animator;
    public BoxCollider2D floor;
    public GameObject guyspawner;
    public GameObject[] guys;
    
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
    }

      void removefloor()
        {
            floor.enabled = false;
        }

        void addfloor()
        {
            floor.enabled = true;
        }

    void spawnGuy()
    {
        Instantiate(guys[UnityEngine.Random.Range(0, guys.Length)], guyspawner.transform.position, quaternion.identity);
    }

}
