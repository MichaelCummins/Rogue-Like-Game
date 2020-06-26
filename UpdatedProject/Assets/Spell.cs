using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spell : MonoBehaviour
{

    public Transform firepoint;
    public GameObject fireballPreFab;

    public double cooldownTime = .8;
    public double nextFireTime = 0;

    Vector3 worldPosition;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){

            if(Time.time > nextFireTime ){
                
                Fireball();
                nextFireTime = Time.time + cooldownTime;
            }
        }
        
    }

    void Fireball(){
       GameObject fireball = Instantiate(fireballPreFab, firepoint.position, firepoint.rotation);
    }
}
