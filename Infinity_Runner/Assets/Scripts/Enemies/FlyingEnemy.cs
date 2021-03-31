using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : Enemies
{
    private Rigidbody2D rig;
    public float speed;

    void Start()
    {
      rig = GetComponent<Rigidbody2D>();  
      Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = Vector2.left * speed;
    }

    
}
