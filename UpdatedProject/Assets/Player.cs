﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    //public float spellDamage = 2f;
    //public float range = 10f;
    //public float resource = 20f;

    public Rigidbody2D rb;

    public Animator animator;
    Vector2 movement;

    public GameObject SpellbookPanel;
    private int counter = 0;


    void Update(){

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if(Input.GetKeyDown("space")){
            showhidePanel();
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
