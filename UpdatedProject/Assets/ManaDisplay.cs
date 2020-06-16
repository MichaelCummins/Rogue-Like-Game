using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaDisplay : MonoBehaviour
{
    public int currentMana;
    public Image mana;
    
    void Start(){
        mana.fillAmount = 0.5f;
    }

    void Update() {

    }
}
