using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float constSpeed;
    public float currentSpeed;
    private Rigidbody rb;
    public float health = 10;
    public float constHealth = 10;
    public ParticleSystem dead_VFX;
    public AudioSource dead_SFX;
   // [SerializeField] private GameObject footer;
    [SerializeField] Slider healthSlider;
   // public GameObject losePAnel, signboardLevels, slider, winPanel;
    public AudioManager audioManager;
    public bool isEmpty;
 
    private UI_Button ui_Button;
    // Gide hands
     public GameObject smallDragon,fly, shark, speedDragon;
  
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        audioManager = FindObjectOfType<AudioManager>();
        ui_Button=FindObjectOfType<UI_Button>();
    }
  
    private void Update()
    {
        Move();
       
    }
    private void Move()
    {
        rb.MovePosition(new Vector3(transform.position.x, transform.position.y, transform.position.z + currentSpeed * Time.deltaTime));
    }
    public void SpeedDecrease(float valueDecrease)
    {
        // currentSpeed = constSpeed / valueDecrease;
        currentSpeed = valueDecrease;
    }
    


    public void ResetHealthAndSpeed()
    {
        currentSpeed = constSpeed;
        health = constHealth;

        // Linking the player's health with the slider
        if (gameObject.transform.parent.tag == "Dragon")
        {
            float healthPercentage = health / constHealth;
            healthSlider.value = healthPercentage;
        }

    }
    IEnumerator GuideHand(GameObject hand)
    {
        yield return new WaitForSeconds(1);
        hand.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Show and hide the guide hand

        if (ui_Button.sceneNumber == 1)
        {
            if (gameObject.transform.parent.tag == "Dragon")
            {
                if(other.gameObject.tag== "SmallDragon")
                {
                    smallDragon.SetActive(true);
                StartCoroutine(GuideHand(smallDragon));
                }
                else if (other.gameObject.tag == "Floor")
                {
                    speedDragon.SetActive(true);
                    StartCoroutine(GuideHand(speedDragon));
                }
                else if (other.gameObject.tag == "Swim")
                {
                    shark.SetActive(true);
                    StartCoroutine(GuideHand(shark));
                }
                else if (other.gameObject.tag == "Empty")
                {
                    fly.SetActive(true);
                    StartCoroutine(GuideHand(fly));
                }
            }

        }
    }

       
      
  
       





       









}
