using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    [SerializeField] private float smoothSpeed=0.125f;
    [SerializeField] Transform target;
    [SerializeField] private Vector3 offset;

    private void Update()
    {
        /*
        Vector3 locationTheCamera = new Vector3(transform.position.x , transform.position.y, transform.position.z) + offset;
        locationTheCamera.x = player.position.x;
        transform.position =locationTheCamera; */

        if(target!= null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            transform.LookAt(target.position);
        }
    }
}
