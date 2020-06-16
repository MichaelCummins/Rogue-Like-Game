using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaDisplay : MonoBehaviour
{
    
    public Image mana;
    public float totalMana;

    void Start(){
        mana.fillAmount = 0.5f;
    }

    void Update() {
        mana.fillAmount = totalMana / 100;

        if(Input.GetMouseButtonDown(0)){
            totalMana--;
        }
    }
}
