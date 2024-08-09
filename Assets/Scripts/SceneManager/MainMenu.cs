using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        FindObjectOfType<LevelManager>().LoadLastLevel();
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
