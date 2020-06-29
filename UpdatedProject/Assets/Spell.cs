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

    public Image mana;
    public float totalMana;


    // Start is called before the first frame update
    void Start(){
        mana.fillAmount = 0.5f;
    }

    // Update is called once per frame
    void Update(){

        mana.fillAmount = totalMana / 100;
        
        if(Input.GetMouseButton(0)){

            if(Time.time > nextFireTime ){
                
                Fireball();
                nextFireTime = Time.time + cooldownTime;
            }
        }
        
    }

    void Fireball(){
        totalMana--;
        if(totalMana > 20){
            totalMana--;
            GameObject fireball = Instantiate(fireballPreFab, firepoint.position, firepoint.rotation);
        }else{
            Debug.Log("Not enough Mana");
        }
    }
}
