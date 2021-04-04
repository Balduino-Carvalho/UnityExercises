using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int hp;
    
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
         if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            OnShoot();
        }
        
         if (Input.GetKeyDown(KeyCode.Space) && !Jumping)
        {
           OnJump();
        }
              

        
    }

    //método de tiro
    public void OnShoot()
    {
         Instantiate(bulletPrefab, firepoint.position,firepoint.rotation);       

    }

    //método de pulo
    public void OnJump()
    {        
            rig.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            anim.SetBool("isJumping", true);
            Jumping = true;        
        
    }
    
    public void OnHit(int dmg)
    {
        hp -= dmg;
        if (hp <= 0)
        {
            GameController.instance.ShowGameOver();
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
