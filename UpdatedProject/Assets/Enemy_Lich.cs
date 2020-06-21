using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Lich : MonoBehaviour
{
    public float health;
    public float range;
    public float speed;

    public Transform target;

    
    // Start is called before the first frame update
    void Start()
    {
       // target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(target.position.x - transform.position.x < 4){
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(health == 0 ){
            Destroy(gameObject);
        }
    }
}
