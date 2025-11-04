using UnityEngine;
using UnityEngine.Rendering;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform spawnPoint1;
    [SerializeField] private Transform spawnPoint2;
    
 
    private int spawnCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Oyuncu alana girdi");

            RandomSpawn();  


            spawnCount++;
            Debug.Log(spawnCount);
        }
    }

    private void RandomSpawn()
    {
        float minX = spawnPoint1.position.x;
        float maxX = spawnPoint2.position.x;

        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPos = new Vector3(randomX, spawnPoint1.position.y, spawnPoint1.position.z);

        GameObject ball = Instantiate(ballPrefab, spawnPos, Quaternion.identity);
    }


    // GameObject ball = Instantiate(ballPrefab, spawnPoint.position, spawnPoint.rotation);
    //                            Spawnlayacaðýmýz obje - Spawnlaya

}
