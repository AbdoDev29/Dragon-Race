using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeCharacters : MonoBehaviour
{
    DeactivateGuideHand assistant;
   public int dragonNumber;
   [SerializeField] private ParticleSystem transformEffect;
   [SerializeField] private AudioSource transformSfx;
   [SerializeField] private Camera cam;
    private void Awake()
    {
        assistant = FindObjectOfType<DeactivateGuideHand>();
        
    }

    public void ChangeDragon()
    {
        if (SceneManager.GetActiveScene().buildIndex==1)
        {
            assistant.DeactivateHand();
            if (cam.GetComponent<AudioListener>().enabled == false)
            {
            cam.GetComponent<AudioListener>().enabled = true;
            }

            if (Time.timeScale == 0)
                Time.timeScale = 1;
        }
            


        GameObject[] currentDragon = GameObject.FindGameObjectWithTag("Player").GetComponent<Dragons>().dragon;
        int activeDragon = 0;

        for(int i=0; i < currentDragon.Length; i++)
        {
            if (currentDragon[i].activeSelf == true)
            {
                activeDragon = i;
                break;
            }
        }

       
        
        Vector3 activeDragonPosition = currentDragon[activeDragon].transform.position;

        Vector3 newPosition = new Vector3(activeDragonPosition.x, activeDragonPosition.y, activeDragonPosition.z + 1);
       
        currentDragon[dragonNumber].transform.position = newPosition;

       

       


       // currentDragon[dragonNumber].transform.position = currentDragon[activeDragon].transform.position;

        currentDragon[activeDragon].SetActive(false);
        currentDragon[dragonNumber].SetActive(true);

        if (currentDragon[dragonNumber] != currentDragon[activeDragon])
        #region Particale and sound
        {
        transformEffect.Play();
      
        Vector3 effectPArtical = new Vector3(currentDragon[activeDragon].transform.position.x, 0, currentDragon[activeDragon].transform.position.z);
        transformEffect.transform.position = effectPArtical;
        transformSfx.transform.position = currentDragon[activeDragon].transform.position;
         transformSfx.Play();
           
        
            #endregion

            #region Reset dragon speed and health
           // When will press on the button the dragon will return the old speed pefor it collider with the rock.
            Movement dragonWillActive = currentDragon[activeDragon].GetComponent<Movement>();
          

            dragonWillActive.ResetHealthAndSpeed();



            #endregion

        }
      
    }


}
