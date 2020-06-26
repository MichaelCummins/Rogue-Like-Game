using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 20;
    public Rigidbody2D rb;

    void Start(){
        rb.velocity = transform.right * speed;
    }


    public void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.name.Equals("Walls")){
            Destroy(gameObject);
        }
    }
}
