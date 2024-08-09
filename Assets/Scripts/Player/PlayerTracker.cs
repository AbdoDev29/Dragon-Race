using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
    public Transform[] Players;

    private void Update()
    {
        foreach(Transform child in Players)
        {
            if (child.gameObject.activeSelf)
            {
                transform.position = child.position;
                break;
            }
        }
    }
}
