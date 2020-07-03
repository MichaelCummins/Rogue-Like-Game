using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    private bool inRange;

    public Transform firepoint;
    public Transform target;
    public GameObject fireballPreFab;

    public double cooldownTime = .8;
    public double nextFireTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        inRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(target.position.x - transform.position.x < 4){
            inRange = true;
        }

        if(inRange){
            if(Time.time > nextFireTime){
                Fireball();
                nextFireTime = Time.time + cooldownTime;
            }
        }
    }

    void Fireball(){
         GameObject fireball = Instantiate(fireballPreFab, firepoint.position, firepoint.rotation);
    }
}
