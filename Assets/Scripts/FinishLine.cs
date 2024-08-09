using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class FinishLine : MonoBehaviour
{
   
    [SerializeField] private int rank;
    
  //  [SerializeField] private GameObject winPanel;
   
    
   
    private Movement movement;
    private GameManager gameManager;
    private void Awake()
    {
        movement = FindObjectOfType<Movement>();
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Movement>())
        {
            // movement.currentSpeed = 0;
            rank++;
            other.GetComponent<Animator>().enabled = false;
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;

            if (other.transform.parent.tag==("Player"))
            {
                other.gameObject.GetComponentInChildren<AudioSource>().enabled = false;
                if (rank == 1)
                {
                    
                    gameManager.Win();
                }
                else
                {
                   
                    gameManager.GameOver();
                   
                }

            }
         
        }
                    
              
                    


        //if (other.transform.parent.tag == ("Player"))
        //{
        //    Debug.Log("The level is finished");
        //    Destroy(other.gameObject.GetComponent<AudioSource>());
        //}

       
    }
}
