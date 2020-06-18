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

        //Debug.Log("Collider " + )
        GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x, currCameraPosition.y + 8, currCameraPosition.z);
    }
}
