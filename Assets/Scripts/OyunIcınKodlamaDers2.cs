using System;
using UnityEngine;

public class OyunIcınKodlamaDers2 : MonoBehaviour
{
    private string playerName = "Ozgur Bulut Gumrukcu";
    private int playerAge = 29;
    private int playerWeight = 110;
    private float playerHeight = 1.83f;
    
    
    private void Awake()
    {
        Debug.Log(playerName + playerAge + playerWeight + playerHeight);
        
        
        Debug.Log("Awake: Script Çalıştı!" + playerName); 
        // Bu fonksiyonun awake'in tanımı için yazdık
        
    }

    private void Start()
    {
        Debug.Log("Start: Oyun Başladı!");
        // Bu fonksiyonun Start'ın tanımı için yazdık
    }

    private void Update()
    {
        Debug.Log("Update: Her Frame'de Çalışıyor!");
        // Bu fonksiyonun Update'in tanımı için yazdık
    }
}
