using System;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    
    private void Awake()
    {
        Debug.Log("Script Yüklendi");
    }

    private void Start()
    {
        Debug.Log("Start: Oyun Başladı");
    }

    private void Update()
    {
        Debug.Log("Update: Her Frame'de çalışıyor");
    }
    
    
}
