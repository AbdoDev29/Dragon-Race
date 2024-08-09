using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTransform : MonoBehaviour
{
    [SerializeField] private int dragonNumber;
    [SerializeField] private float maxNumber;
    private Movement movement;
    private GameObject oldDragon;
    private void Awake()
    {
        movement = FindObjectOfType<Movement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Movement>())
        {
            oldDragon = other.gameObject;
            gameObject.GetComponent<Collider>().enabled = false;
        }
        Invoke("ChangeDragonAfterTime", Random.Range(1,maxNumber)); // This is the time when the enemy will change his personality to another personality.
    }

    public void ChangeDragonAfterTime()
    {
        GameObject activeDragon = oldDragon.transform.parent.GetChild(dragonNumber).gameObject;

        oldDragon.gameObject.SetActive(false);
        activeDragon.SetActive(true);
        activeDragon.transform.position = oldDragon.transform.position;
        activeDragon.GetComponent<Movement>().ResetHealthAndSpeed();
        //vfx
        GameObject vfx = activeDragon.GetComponent<Movement>().dead_VFX.gameObject;
        vfx.transform.position = activeDragon.transform.position;
        movement.dead_VFX.Play();

        //sfx
        GameObject sfx = activeDragon.GetComponent<Movement>().dead_SFX.gameObject;
        sfx.transform.position = activeDragon.transform.position;
       // movement.dead_SFX.Play();
    }
    
}
