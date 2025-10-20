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
    

    private void Start()
    {
        int diploma = 85;

        switch (diploma)
        {
            case >= 90 and <= 100:
                Debug.Log("AA");
                break;

            case >= 80 and < 90:
                Debug.Log("BA");
                break;

            case >= 70 and < 80:
                Debug.Log("BB");
                break;

            default:
                Debug.Log("Geçersiz Not");
                break;
        }

    }
}
