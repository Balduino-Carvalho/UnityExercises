using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rig;
    public float speed;
    public int bulletDamage;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rig.velocity = Vector2.right * speed;
    }
}
