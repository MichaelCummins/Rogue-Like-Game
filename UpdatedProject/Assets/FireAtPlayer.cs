using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAtPlayer : MonoBehaviour
{
    public Transform host;
    public Transform targetPlayer;

    private Vector3 target;
    private Vector3 host_pos;

    private float angle;

    void Update(){
        /*
        target = GameObject.FindGameObjectWithTag("Player").transform.position - transform.parent.position;
        target.z = -20;
        host_pos = host.position;
        target.x = target.x - host_pos.x;
        target.y = target.y - host_pos.y;
        angle = Mathf.Atan2(target.y, target.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
        */

        Vector3 targetDir = targetPlayer.position - transform.position;
        angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q , 90 * Time.deltaTime);
    }
}
