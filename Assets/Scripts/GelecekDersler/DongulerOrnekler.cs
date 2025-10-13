using System;
using System.Collections.Generic;
using UnityEngine;

public class DongulerOrnekler : MonoBehaviour
{
    /*
     * While
     * DoWhile
     * Foreach
     * 
     *Döngüler Nedir?
       Döngüler, belirli bir koşul sağlandığı sürece belirli bir kod bloğunu tekrar tekrar çalıştırmak için kullanılır. 
       Programlama dillerinde yaygın olarak kullanılan döngü türleri arasında `for`, `foreach`, `while` ve `do-while` döngüleri bulunmaktadır.
 
     */
    
    
    
    private void Start()
    {
        
    }

    private void WhileDongu()
    {
        int count = 0;
        while (count < 5) {
            Debug.Log("Count: " + count);
            count++;
        }
    }

    private void ForeachDongu()
    {
        List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
        foreach (string name in names) {
            Console.WriteLine("Name: " + name);
        }
    }

    private void DoWhileDongu()
    {
        int number = 0;
        do {
            Console.WriteLine("Number: " + number);
            number++;
        } while (number < 5);
    }
    
}
