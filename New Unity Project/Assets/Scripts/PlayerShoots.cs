using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoots : MonoBehaviour
{
    public GameObject projectile;
    public GameObject point;
    public float bulletSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate (projectile);
            bullet.transform.position = point.transform.position;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward*bulletSpeed, ForceMode.Impulse);
        }
    }
}
