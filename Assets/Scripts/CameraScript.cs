using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject target;
    
    void Update()
    {
        if (target != null)
        {
            Vector3 newPosition = transform.position;
            newPosition.x = target.transform.position.x;
            newPosition.y = target.transform.position.y;

            transform.position = newPosition;
        }
    }
}