using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleLevelManager : MonoBehaviour
{
    // Method to load a specific level by its scene name
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    // Method to load the next level based on the current scene's name
    public void LoadNextLevel()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        int nextLevelIndex = SceneManager.GetSceneByName(currentScene).buildIndex + 1;
        
        if (nextLevelIndex >= SceneManager.sceneCountInBuildSettings)
        {
            // Loop back to the first level if all levels are completed
            nextLevelIndex = 0;
        }

        SceneManager.LoadScene(nextLevelIndex);
    }
}
