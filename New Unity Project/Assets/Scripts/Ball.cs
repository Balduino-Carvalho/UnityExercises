 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody Rig;
    public float Vel = 500;
    public float JumpForce=8.5f;
    private bool onTheFloor;

    void Start()
    {
        Rig = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rig.AddForce (Vector3.left*Vel*Time.deltaTime, ForceMode.Acceleration);
        }
        if (onTheFloor && Input.GetKeyDown(KeyCode.Space))
        {
            Rig.AddForce (Vector3.up*JumpForce, ForceMode.Impulse);
            onTheFloor = false;
        }
    }
    private void OnCollisionEnter (Collision collision)
    {
        if(collision.gameObject.layer == 6)
        {
            onTheFloor = true;
        }
    }
}
