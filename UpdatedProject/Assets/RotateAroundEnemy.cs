using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundEnemy : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = target.position;

        float angle = Mathf.Atan2(dir.y + 1, dir.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rotation;       
    }
}
