using UnityEngine;
using System;

public class KosullarOrnekler : MonoBehaviour
{
    /*
    Switch-Case: Bir değişkenin değerine göre farklı durumlara göre farklı kod blokları çalıştırmak için kullanılır.
        Genel yapı:
    switch (değişken)
    {
        case değer1:
        // değer1 için çalışacak kod
        break;
        case değer2:
        // değer2 için çalışacak kod
        break;
        default:
        // Hiçbir koşul sağlanmazsa çalışacak kod
        break;
    }
    
    */

    int ogrenciNot = 90;

    private void Start()
    {
        switch (ogrenciNot)
        {
            case 100:
                Debug.Log("Mükemmel not!");
                break;
            case 85:
                Debug.Log("Çok iyi!");
                break;
            case 70:
                Debug.Log("İyi.");
                break;
            default:
                Debug.Log("Belirtilmemiş not");
                break;
        }
    }
}
