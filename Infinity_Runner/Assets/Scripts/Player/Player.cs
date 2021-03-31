using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rig;
    public Animator anim;

    public float speed;
    public float JumpForce;
    private bool Jumping;

    public GameObject bulletPrefab;
    public Transform firepoint;

    void Start()
    {
       rig = GetComponent<Rigidbody2D>(); 
    }

    void FixedUpdate() //melhor para se trabalhar com a física constante na unity
    {
        rig.velocity = new Vector2(speed,rig.velocity.y);
    }
   
    void Update()
    {
        //pulo
        if (Input.GetKeyDown(KeyCode.Space) && !Jumping)
        {
            rig.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            anim.SetBool("isJumping", true);
            Jumping = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Instantiate(bulletPrefab, firepoint.position,firepoint.rotation);
        }
    }

    //verificador se está pulando
    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            anim.SetBool("isJumping", false);
            Jumping = false;
        }
    }
}
