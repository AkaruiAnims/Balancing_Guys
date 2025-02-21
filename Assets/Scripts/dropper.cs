using System;
using System.Collections;
using System.Security.Cryptography;
using Unity.VisualScripting.ReorderableList;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class dropper : MonoBehaviour
{
    

public GameObject Crane;

public Transform position;
public float speed;
public Transform end;
public Transform start;
Vector3 targetPos;



    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetPos = end.position;
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.Space))
        {

        }


        if(Vector2.Distance(Crane.transform.position, end.position) < 0.05f)
        {
            targetPos = start.position;
        }

        if(Vector2.Distance(Crane.transform.position, start.position) < 0.05f)
        {
            targetPos = end.position;
        }

      Crane.transform.position = Vector3.MoveTowards(Crane.transform.position, targetPos, speed * Time.deltaTime);
    }
}
