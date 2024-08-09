using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private const string lastLevelKey = "LastLevel";
    
    // Save the current level.
    public static void SaveLevel(int levelIndex)
    {
        PlayerPrefs.SetInt(lastLevelKey, levelIndex);
        PlayerPrefs.Save();
    }

    // Recover the last level.
    public static int GetSavedLevel()
    {
        return PlayerPrefs.GetInt(lastLevelKey, 1);
    }

    // Go to the saved level.
    public void LoadLastLevel()
    {
        int levelIndex = GetSavedLevel();
        SceneManager.LoadScene(levelIndex);
     
    }

    // Go to the next level.
    public void LoadNextLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        int nextLevel = currentLevel + 1;
        SaveLevel(nextLevel);
        SceneManager.LoadScene(nextLevel);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
