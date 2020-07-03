using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundEnemy : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = target.position - transform.position;

        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rotation;       
    }
}
