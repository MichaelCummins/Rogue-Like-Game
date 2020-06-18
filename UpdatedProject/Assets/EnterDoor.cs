using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDoor : MonoBehaviour
{
    public int Direction;
    public float cameraSpeed = .125f; 
    private int rand;
    private RoomTemplates templates;
    Vector3 currCameraPosition;
    Vector3 currPlayerPosition;

    private void Start() {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        currCameraPosition = GameObject.Find("Main Camera").transform.position;
    }

    private void Update() {
        currPlayerPosition = GameObject.Find("Player").transform.position;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            if(Direction == 1){
                GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x, currCameraPosition.y + 8, currCameraPosition.z);
                currCameraPosition = new Vector3(currCameraPosition.x, currCameraPosition.y + 8, currCameraPosition.z);
               // other.transform.position =  new Vector3(currPlayerPosition.x, currPlayerPosition.y + 3, currPlayerPosition.z);
            } else if(Direction == 2){
                GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x, currCameraPosition.y - 8, currCameraPosition.z);
                currCameraPosition = new Vector3(currCameraPosition.x, currCameraPosition.y - 8, currCameraPosition.z);
               // other.transform.position =  new Vector3(currPlayerPosition.x, currPlayerPosition.y - 2, currPlayerPosition.z);
            } else if(Direction == 3){
                GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x + 14, currCameraPosition.y, currCameraPosition.z);
                currCameraPosition = new Vector3(currCameraPosition.x + 14, currCameraPosition.y, currCameraPosition.z);
               // other.transform.position =  new Vector3(currPlayerPosition.x + 2, currPlayerPosition.y, currPlayerPosition.z);
            } else if(Direction == 4){
                GameObject.Find("Main Camera").transform.position = new Vector3(currCameraPosition.x - 14, currCameraPosition.y, currCameraPosition.z);
                currCameraPosition = new Vector3(currCameraPosition.x - 14, currCameraPosition.y, currCameraPosition.z);
              //  other.transform.position =  new Vector3(currPlayerPosition.x - 2, currPlayerPosition.y, currPlayerPosition.z);
            } else{
                Debug.Log("This shouldnt be seen, a spawnpoint is missing a direction");
            }
        }
    }
}
