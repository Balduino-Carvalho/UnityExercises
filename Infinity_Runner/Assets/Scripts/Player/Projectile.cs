using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rig;
    public float speed;
    public int bulletDamage;

    public GameObject expPrefab;

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

    public void OnHit ()
    {
       GameObject e = Instantiate (expPrefab, transform.position, transform.rotation);
       Destroy(e,0.3f);
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            OnHit();
        }
    }


}
