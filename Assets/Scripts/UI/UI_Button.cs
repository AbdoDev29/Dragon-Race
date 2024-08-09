
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Button : MonoBehaviour
{
    public int sceneNumber;
    [SerializeField] private Slider slider;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject endLine;
    [SerializeField] private GameObject startPanel;
    private float maxDistance;


    private void Start()
    {
        Time.timeScale = 1;

        maxDistance = GetDistance();

  
  
    }

    private void Update()
    {
      
      
        // Slider
        if (player.transform.position.z <= maxDistance && player.transform.position.z <= endLine.transform.position.z)
        {
            float distance =1- (GetDistance() / maxDistance); // = 1
            SetValue(distance); // slider value =1
        }
    }

 
  
 
    public void Quit()
    {
        Application.Quit();
    }
    
    float GetDistance() // Slider
    {
        return Vector3.Distance(player.transform.position, endLine.transform.position);
    }

    private void SetValue(float P)
    {
        slider.value = P;
    }

    
 
}
