using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 3;
    public Rigidbody2D rb;

    private float timeAlive = 0;
    
    private float lifeTime = 3;

    void Start(){
        rb.velocity = transform.right * speed;
        Destroy(gameObject,lifeTime);
    }

    void Update(){
        timeAlive += Time.deltaTime;
    }

    public void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag.Equals("Wall") || collision.gameObject.tag.Equals("Lich")){
            Destroy(gameObject);
        }
    }
}
