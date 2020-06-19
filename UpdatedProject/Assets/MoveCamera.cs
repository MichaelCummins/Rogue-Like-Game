using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{


    private string currCollider;

    Vector3 currCameraPosition;

    private void Start() {
        currCameraPosition = GameObject.Find("Main Camera").transform.position;
        currCollider =  transform.name;
    }

    private void Update() {
        currCameraPosition = GameObject.Find("Main Camera").transform.position;
    }
    
    private void OnTriggerEnter2D(Collider2D other) {

        if(currCollider == "NorthCollider"){
            GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x, currCameraPosition.y + 8, currCameraPosition.z);
            currCameraPosition = GameObject.Find("Main Camera").transform.position;
        }else if(currCollider == "SouthCollider"){
            GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x, currCameraPosition.y - 8, currCameraPosition.z);
            currCameraPosition = GameObject.Find("Main Camera").transform.position;
        }else if(currCollider == "WestCollider"){
            GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x + 14, currCameraPosition.y, currCameraPosition.z);
            currCameraPosition = GameObject.Find("Main Camera").transform.position;
        }else if(currCollider == "EastCollider"){
            GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x - 14, currCameraPosition.y, currCameraPosition.z);
            currCameraPosition = GameObject.Find("Main Camera").transform.position;
        }else{
            Debug.Log("You shouldnt be seeing this");
        }
        //Debug.Log("Collider " + )
    }
}
