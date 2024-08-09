using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    SpawnerManager spawnerManager;
  
    void Awake()
    {
        spawnerManager = FindObjectOfType<SpawnerManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.z< spawnerManager.cameraMain.transform.position.z+4)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == ("Empty"))
        {
            print("the cone is collided with the empty");
            Destroy(this.gameObject);
        }
    }
}
