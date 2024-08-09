using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    [SerializeField] private float maxTime;
    [SerializeField] private Text timerText;
    [SerializeField] private Image fill;
    
    [SerializeField] private GameObject panelTime; // this include the timer and timer circle

    
    void Update()
    {
        time -= Time.deltaTime;
        timerText.text = "" + (int)time;
        fill.fillAmount = time / maxTime;

        if (time < 0)
        {
            time = 0;
            panelTime.SetActive(false);
        }
    }
}
           
