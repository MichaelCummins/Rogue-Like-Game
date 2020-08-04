using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;


    public Rigidbody2D rb;

    public Animator animator;
    Vector2 movement;
    private bool playerMoving;
    private Vector2 lastMove;

    public GameObject SpellbookPanel;
    private int counter = 0;

    private Spell spells;


    void Start(){
        
    }

    void Update(){

        playerMoving = false;

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        if(movement.x > .5f || movement.x < -.5f){
            animator.SetFloat("Horizontal", movement.x);
            playerMoving = true;
            lastMove = new Vector2(movement.x, movement.y);
        }

        if(movement.y > .5f || movement.y < -.5f){
            animator.SetFloat("Vertical", movement.y);
            playerMoving = true;
            lastMove = new Vector2(movement.x, movement.y);
        }
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        animator.SetBool("PlayerMoving", playerMoving);
        animator.SetFloat("LastMoveX", lastMove.x);
        animator.SetFloat("LastMoveY", lastMove.y);

        if(Input.GetKeyDown("space")){
            showhidePanel();
        }

        if(Input.GetKeyDown("1")){
           // castFireball();
        }

        
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void showhidePanel(){
        counter++;
        if(counter % 2 == 1){
            SpellbookPanel.gameObject.SetActive(false);
        }else{
            SpellbookPanel.gameObject.SetActive(true);
        }
    }
}
