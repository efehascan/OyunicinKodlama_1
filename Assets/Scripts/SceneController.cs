
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class SceneController : MonoBehaviour
{
    public void NextScene()
    {
        int currentScene = UnitySceneManager.GetActiveScene().buildIndex;
        int nextScene = currentScene + 1;

        if (nextScene < UnitySceneManager.sceneCountInBuildSettings)
        {
            UnitySceneManager.LoadScene(nextScene);
        }
        else
        {
            Debug.Log("Son level tamamlandý!");
        }
    }

    public void NextLevel()
    {
        NextScene();
    }

    public void RestartScene()
    {
        int currentScene = UnitySceneManager.GetActiveScene().buildIndex;

        UnitySceneManager.LoadScene(currentScene);
    }

    public void MainMenu()
    {
        UnitySceneManager.LoadScene(0);
    }

    public void LoadLevel(int levelIndex)
    {
        if (levelIndex >= 0 &&
            levelIndex < UnitySceneManager.sceneCountInBuildSettings)
        {
            UnitySceneManager.LoadScene(levelIndex);
        }
    }
}
