using UnityEngine;

public class ProjectEuler : MonoBehaviour
{
    private int sayi;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Cozum();
    }

    private void Cozum()
    {
        for (int i =0; i<1000 ; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sayi += i;
                
            }   
        }
        Debug.Log("Sayı:" + sayi);
        
    }
}
