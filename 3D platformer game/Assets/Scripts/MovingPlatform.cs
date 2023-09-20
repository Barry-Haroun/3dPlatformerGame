using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform platform;
    public Transform startPoint;
    public Transform endPoint;
    public float speed = 1.0f;
    int direction = 1;

    private void FixedUpdate()
    {
        Vector3 target = currentMovementTarget();
        platform.position = Vector3.Lerp(platform.position, target, speed * Time.deltaTime);

        float distance = (target - (Vector3)platform.position).sqrMagnitude;

        if (distance <= 0.1f) 
        {
            direction *= -1;
        }
    }

    Vector3 currentMovementTarget()
    {
        if (direction == 1)
        {
            return startPoint.position;
        }
        else 
        { 
            return endPoint.position;
        }
    }



}
