using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //References for Wim panal and lose panal
    public GameObject losePanel,slider, winPanel, footer, tweenUI_Win, tweenUI_Lose,pausePanal,pauseButton;
    public Camera mainCamera;
    public GameObject[] hands;
    private void Start()
    {
        LevelManager.SaveLevel(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnPlayerDeath()
    {
        ReloadCurrentLevel();
    }

    public void ReloadCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Win()
    {
        tweenUI_Win.SetActive(true);
        footer.SetActive(false);
        slider.SetActive(false);
        pauseButton.SetActive(false);
        winPanel.SetActive(true);
    }

    public void GameOver()
    {
        tweenUI_Lose.SetActive(true);
        losePanel.SetActive(true);
        footer.SetActive(false);
        pauseButton.SetActive(false);
        slider.SetActive(false);
    }


    public void Pause()
    {
        Time.timeScale = 0;
        pausePanal.SetActive(true);
        mainCamera.GetComponent<AudioListener>().enabled = false;

        // Disabeld all hands when the game is stopped.
        foreach(GameObject Hand in hands)
        {
            Hand.SetActive(false);
        }
    }
    public void Resume()
    {
        Time.timeScale = 1;
        pausePanal.SetActive(false);
        mainCamera.GetComponent<AudioListener>().enabled = true;

    }
}
