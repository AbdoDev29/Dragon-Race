using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateGuideHand : MonoBehaviour
{
    public void DeactivateHand()
    {
        foreach (Transform child in transform)
        {
            if (child.gameObject.activeSelf)
            {
                child.gameObject.SetActive(false);
            }

        }
    }
}
