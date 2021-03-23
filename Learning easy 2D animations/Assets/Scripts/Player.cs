using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float timeAttack;
    public float startTimeAttack;
    public float JumpForce;
    private bool isGrounded;
    public float Speed;
    private Rigidbody2D rig;
    private Animator anim;
    private SpriteRenderer sprite;
    
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private bool isAtk;
    void Update()
    {
        
        //Movimento
        if (Input.GetKey(KeyCode.LeftArrow) && !isAtk)
        {
            rig.velocity = new Vector2 (-Speed, rig.velocity.y);
            anim.SetBool("isWalking",true);
            sprite.flipX = true;
        }
        else
        {
            rig.velocity = new Vector2 (0, rig.velocity.y);
            anim.SetBool("isWalking",false);
        }
        if (Input.GetKey(KeyCode.RightArrow) && !isAtk)
        {
            rig.velocity = new Vector2 (Speed, rig.velocity.y);
            anim.SetBool("isWalking",true);
            sprite.flipX = false;
        }
        //Pulo
        if(Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
        
            rig.AddForce(Vector2.up*JumpForce, ForceMode2D.Impulse);
            isGrounded = false;
            anim.SetBool("isJumping",true);
        }
        if (timeAttack <= 0)
        {
            isAtk = false;
            if(Input.GetKeyDown(KeyCode.Z))
            {
                anim.SetBool("isAtk",true);
                timeAttack = startTimeAttack;
                isAtk = true;
            }
            
        }
        else
        {
            timeAttack -= Time.deltaTime;
            anim.SetBool("isAtk",false);
        }
        anim.SetBool ("isAtk",isAtk);

    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.layer == 3)
        {
            isGrounded = true;
            anim.SetBool("isJumping",false);;
        }
    }
}
