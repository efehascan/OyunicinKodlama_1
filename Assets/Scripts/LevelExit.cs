using UnityEngine;

public class LevelExit : MonoBehaviour
{
    [SerializeField] private int requiredScore = 50;

    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private SceneController sceneController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (scoreManager.GetScore() >= requiredScore)
            {
                Debug.Log("Yeterli puan! Sonraki level açýlýyor.");

                sceneController.NextScene();
            }
            else
            {
                Debug.Log("Yeterli puan yok!");
            }
        }
    }
}