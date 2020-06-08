using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    //public float spellDamage = 2f;
    //public float range = 10f;
    //public float resource = 20f;

    //float velX;
    //float velY;
    public Rigidbody2D rb;
    //public SpriteRenderer spriteRenderer;
    //public Sprite spLeft, spRight, spUp, spDown, spTopLeft, spTopRight, spBotLeft, spBotRight;

    public Animator animator;
    Vector2 movement;



    void Update(){

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);


/*

        if(Input.GetKey("w")){
           gameObject.GetComponent<SpriteRenderer>().sprite = spUp;
        }
        if(Input.GetKey("a")){
           gameObject.GetComponent<SpriteRenderer>().sprite = spLeft;
        }
        if(Input.GetKey("s")){
           gameObject.GetComponent<SpriteRenderer>().sprite = spDown;
        }
        if(Input.GetKey("d")){
           gameObject.GetComponent<SpriteRenderer>().sprite = spRight;
        }

        if(Input.GetKey("w") && Input.GetKey("a")){
            gameObject.GetComponent<SpriteRenderer>().sprite = spTopLeft;
        }
        
        if(Input.GetKey("w") && Input.GetKey("d")){
            gameObject.GetComponent<SpriteRenderer>().sprite = spTopRight;
        }

        if(Input.GetKey("s") && Input.GetKey("a")){
            gameObject.GetComponent<SpriteRenderer>().sprite = spBotLeft;
        }

        if(Input.GetKey("s") && Input.GetKey("d")){
            gameObject.GetComponent<SpriteRenderer>().sprite = spBotRight;
        }
        */
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
