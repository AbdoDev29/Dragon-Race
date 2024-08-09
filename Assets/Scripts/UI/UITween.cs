using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UITween : MonoBehaviour
{
    [SerializeField] private GameObject backPanel, nextLevelButton,replayButton, star1, star2, star3, colorWheel, levelSuccess;
    [SerializeField] Camera mainCamera;
    void Start()
    {
        LeanTween.rotateAround(colorWheel, Vector3.forward, -360, 10f).setLoopClamp();
        LeanTween.scale(levelSuccess, new Vector3(4.30f, 1.26f, 18f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic).setOnComplete(LevelComplete);
        LeanTween.moveLocal(levelSuccess, new Vector3(3f, 177.97f, 2f), .7f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(levelSuccess, new Vector3(4.26f, 1.22f, 16f), 2f).setDelay(1.7f).setEase(LeanTweenType.easeInOutCubic);
    }


    void LevelComplete()
    {
        mainCamera.GetComponent<AudioListener>().enabled = false;
        LeanTween.moveLocal(backPanel, new Vector3(3.8f, -95f, 0f), 0.7f).setDelay(.5f).setEase(LeanTweenType.easeOutCirc).setOnComplete(StarsAnim);
        LeanTween.scale(replayButton, new Vector3(1f, 1f, 1f), 2f).setDelay(.9f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(nextLevelButton, new Vector3(1f, 1f, 1f), 2f).setDelay(.8f).setEase(LeanTweenType.easeOutElastic);
       
       // LeanTween.alpha(congratulation.GetComponent<RectTransform>(), 255f, .5f).setDelay(1f);
    }

    void StarsAnim()
    {
        LeanTween.scale(star1, new Vector3(1.11f, 1.11f, 1.11f), 2f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(star2, new Vector3(1.11f, 1.11f, 1.11f), 2f).setDelay(.1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(star3, new Vector3(1.11f, 1.11f, 1.11f), 2f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic);
        
    }
}
