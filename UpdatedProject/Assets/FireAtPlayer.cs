using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAtPlayer : MonoBehaviour
{
    public Transform host;

    private Vector3 target;
    private Vector3 host_pos;

    private float angle;

    void Update(){
        target = GameObject.FindGameObjectWithTag("Player").transform.position;
        host_pos = Camera.main.WorldToScreenPoint(host.position);
        target.x = target.x - host_pos.x;
        target.y = target.y - host_pos.y;
        angle = Mathf.Atan2(target.y, target.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
