using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UITweenMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject titleGame, startButton, exitButton;

    private void Start()
    {
        LeanTween.scale(titleGame, new Vector3(0.9f, 0.9f, 0.9f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic).setOnComplete(Buttons);
        LeanTween.moveLocal(titleGame, new Vector3(0f, 0f, 0f), .7f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(titleGame, new Vector3(1f, 1f, 1f), 2f).setDelay(1.7f).setEase(LeanTweenType.easeInOutCubic);
    }
    private void Buttons()
    {
        LeanTween.scale(startButton, new Vector3(2f, 3f, 1f), 2f).setDelay(.9f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(exitButton, new Vector3(2f, 3f, 1f), 2f).setDelay(.8f).setEase(LeanTweenType.easeOutElastic);
    }
}
