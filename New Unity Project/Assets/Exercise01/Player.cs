using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float Vel;
    public float Rot;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate (Vector3.forward*Vel*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate (-Vector3.forward*Vel*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up*Rot*Time.deltaTime);
        }
         if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.up*Rot*Time.deltaTime);
        }


    }
}
