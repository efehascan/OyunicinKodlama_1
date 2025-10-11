using UnityEngine;

public class Donguler : MonoBehaviour
{
    private int maxValue = 100;
    private int count = 0;
    
    /*
     *
     * `for` döngüsü, belirli bir sayıda tekrarı ifade eder. Genellikle bir sayaç kullanarak belirli bir koşul sağlandığı sürece döngüyü çalıştırır.
       
       Yapısı:
       for (başlangıç_değeri; koşul; artış) {
           // Tekrar eden kod bloğu
       }

       Örnek:
       for (int i = 0; i < 5; i++) {
           Console.WriteLine("i: " + i);
       }
     * 
     */

    void Start()
    {
        for (int i = 0; i < maxValue; i++)
        {
            if (i % 2 == 0)
            {
                count++;
                //Debug.Log(count);
                // Buradaki debug.log i sayısı her 2ye bölündüğünde çalışır bu sayede her seferinde 1,2,3,4... diye gider
                
            }
            
            //Debug.Log(count);
            // Buradaki debug.log for döngüsünde her tekrarda çalışır bu sayede count artmadan aynı Debug birden fazla kez konsola yazdırır
                
            
             Debug.Log(i);
             // Burada döngüde sıra hangi sayıda onu görmemizi sağlar her döngüye giren i sayısını konsola yazdırırız.
        }
        
        //Debug.Log(count);
        // Buradaki Debug.Log Döngü bittiğinde direkt olarak sonucu konsola yazdırır    
    }
}
