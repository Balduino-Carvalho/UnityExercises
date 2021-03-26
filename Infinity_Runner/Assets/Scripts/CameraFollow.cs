using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    private Transform player;
    public float speed;
    

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    void Update()
    {
        Vector3 newCamPos = new Vector3(player.position.x, 0f, transform.position.z);
        transform.position = Vector3.Slerp(transform.position,newCamPos, speed * Time.deltaTime);
    }
}
