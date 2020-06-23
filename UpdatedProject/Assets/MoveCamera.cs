using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{


    private string currCollider;

    private float timer = 0.0f;
    private float wait = 1;

    Vector3 currCameraPosition;
    Vector3 currPlayerPosition;

    private void Start() {
        currCameraPosition = GameObject.Find("Main Camera").transform.position;
        currPlayerPosition = GameObject.Find("Player").transform.position;
        currCollider =  transform.name;
    }

    private void Update() {
        currCameraPosition = GameObject.Find("Main Camera").transform.position;
        currPlayerPosition = GameObject.Find("Player").transform.position;
        timer += Time.deltaTime;
        
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player" && timer >= wait){
            timer = 0;
            GetComponent<Collider2D>().enabled = false;
            if(currCollider == "NorthCollider"){
                GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x, currCameraPosition.y + 8, currCameraPosition.z);
                GameObject.Find("Player").transform.position = new Vector3(currPlayerPosition.x, currPlayerPosition.y + 2, currPlayerPosition.z);
            }else if(currCollider == "SouthCollider"){
                GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x, currCameraPosition.y - 8, currCameraPosition.z);
                GameObject.Find("Player").transform.position = new Vector3(currPlayerPosition.x, currPlayerPosition.y - 2, currPlayerPosition.z);
            }else if(currCollider == "WestCollider"){
                GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x + 14, currCameraPosition.y, currCameraPosition.z);
                GameObject.Find("Player").transform.position = new Vector3(currPlayerPosition.x + 2, currPlayerPosition.y, currPlayerPosition.z);
            }else if(currCollider == "EastCollder"){
                GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x - 14, currCameraPosition.y, currCameraPosition.z);
                GameObject.Find("Player").transform.position = new Vector3(currPlayerPosition.x - 2, currPlayerPosition.y, currPlayerPosition.z);
            }else{
                Debug.Log("You shouldnt be seeing this");
            }  
        }

        GetComponent<Collider2D>().enabled = true;
    }
}
