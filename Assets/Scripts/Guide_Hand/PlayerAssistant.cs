using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAssistant : MonoBehaviour
{
    private ChangeCharacters changeCharacters;
    [SerializeField] private string tagName;
    [SerializeField] private GameObject pachyHand, sharkHand, dragonFlyHand, smallDragonHand;
    [SerializeField] private Camera cam;

    private void Awake()
    {
        changeCharacters = FindObjectOfType<ChangeCharacters>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.transform.parent.tag == "Player")
        {
            Time.timeScale = 0f;
            cam.GetComponent<AudioListener>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;

            switch (tagName)
            {
               
                case "pachy":
                       pachyHand.SetActive(true);
                       cam.GetComponent<AudioListener>().enabled = false;
                 break;
                   
                case "shark":
                        sharkHand.SetActive(true);
                        cam.GetComponent<AudioListener>().enabled = false;
                    break; 
                   
                case "smallDragon":
                        cam.GetComponent<AudioListener>().enabled = false;
                        smallDragonHand.SetActive(true);
                  
                    break;
                   
                case "dragonFly":
                   
                        dragonFlyHand.SetActive(true);
                        GetComponent<BoxCollider>().enabled = false;
                    
                    break;
                       
                 
                  
                   
                   
                   

                
                    
                   
                       

                        
                 


            }
          

        }
    }
    


  

}
