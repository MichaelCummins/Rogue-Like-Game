using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Collider2D northCollider;
    public Collider2D southCollider;
    public Collider2D westCollider;
    public Collider2D eastCollider;

    Vector3 currCameraPosition;

    private void Start() {

        currCameraPosition = GameObject.Find("Main Camera").transform.position;
    }
    
    private void OnTriggerEnter2D(Collider2D other) {

        if(northCollider){
            GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x, currCameraPosition.y + 8, currCameraPosition.z);
            currCameraPosition = GameObject.Find("Main Camera").transform.position;
        }else if(southCollider){
            GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x, currCameraPosition.y - 8, currCameraPosition.z);
            currCameraPosition = GameObject.Find("Main Camera").transform.position;
        }else if(westCollider){
            GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x + 14, currCameraPosition.y, currCameraPosition.z);
            currCameraPosition = GameObject.Find("Main Camera").transform.position;
        }else if(eastCollider){
            GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x - 14, currCameraPosition.y, currCameraPosition.z);
            currCameraPosition = GameObject.Find("Main Camera").transform.position;
        }else{
            Debug.Log("You shouldnt be seeing this");
        }
        //Debug.Log("Collider " + )
    }
}
