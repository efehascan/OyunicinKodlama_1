using UnityEngine;

public class OperatorExamples : MonoBehaviour
{
    void Start()
    {
        // Değişken tanımlama
        int a = 5;   // a isimli değişkenin değeri 5
        int b = 10;  // b isimli değişkenin değeri 10

        // --- Aritmetik Operatörler ---
        int toplam = a + b;   // a ve b'yi toplar (5 + 10 = 15)
        int kalan = b % a;    // b'nin a'ya bölümünden kalanı bulur (10 % 5 = 0)

        // --- Karşılaştırma Operatörleri ---
        bool buyukMu = b > a; // b, a'dan büyük mü? (true döner)

        // --- Mantıksal Operatörler ---
        // a ve b sıfırdan büyükse true döner
        bool ikiKosul = (a > 0 && b > 0); // VE (AND) operatörü

        // --- Üçlü (Ternary) Operatör ---
        // a, b'den büyükse max = a; değilse max = b
        int max = (a > b) ? a : b;

        // --- Sonuçları ekrana yazdır ---
        Debug.Log("Toplam: " + toplam);
        Debug.Log("Kalan: " + kalan);
        Debug.Log("b, a'dan büyük mü?: " + buyukMu);
        Debug.Log("İki koşul da doğru mu?: " + ikiKosul);
        Debug.Log("En büyük sayı: " + max);
    }
}