using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Lich : MonoBehaviour
{
    public float health;
    public float range;
    public float speed;

    public Transform target;

    public Animator animator;
    Vector2 movement;
    private bool LichMoving;

    Vector2 heading;
    float distance;
    Vector2 direction;

    void Start(){
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        heading = target.position - transform.position;
        distance = heading.magnitude;
        direction = heading / distance;

        Debug.Log("Distance: " + distance + " direction: " + direction);

        movement.x = direction.x;
        movement.y = direction.y;

        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime); 
    
        if(movement.x > .5f || movement.x < -.5f){
            animator.SetFloat("Horizontal", movement.x);
            LichMoving = true;
        }

        if(movement.y > .5f || movement.y < -.5f){
            animator.SetFloat("Vertical", movement.y);
            LichMoving = true;
        }

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        animator.SetBool("PlayerMoving", LichMoving);
    

        if(health == 0 ){
            Destroy(gameObject);
        }
    
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag.Equals("Fireball")){
            health--;
            //Destroy(other);
        }
    }
}
