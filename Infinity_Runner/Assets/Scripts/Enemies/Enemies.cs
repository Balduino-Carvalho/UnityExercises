using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public int health;
    public int damage;


    public virtual void ApplyDamage(int dmg)
    {
        health -= dmg;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.CompareTag("bullet"))
      {
          ApplyDamage(collision.GetComponent<Projectile>().bulletDamage);
         collision.GetComponent<Projectile>().OnHit(); 
      }
    }

}
