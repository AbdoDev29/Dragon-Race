using UnityEngine;

public class GearRotate : MonoBehaviour
{
    [SerializeField] private float speedRotate;
    void Update()
    {
        transform.Rotate(0f, 0f, speedRotate * Time.deltaTime);
    }
}
