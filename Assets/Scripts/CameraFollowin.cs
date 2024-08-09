using UnityEngine;

public class CameraFollowin : MonoBehaviour
{
    public Vector3 offset;
    public Transform cube;
    public float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;
    void Update()
    {
        Vector3 targetPosition = cube.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
