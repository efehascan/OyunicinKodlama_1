using UnityEngine;

public class Kosullar : MonoBehaviour
{
    private bool isRaining = true;
    private bool isTraffic = true;
    private string message = "Bulut Hoca derse geç kalır";
    private string message2 = "Bulut Hoca derse zamanında gelir";
    private string message3 = "Bulut Hoca derse çok geç kaldı";

    private void Awake()
    {
        isRaining = true;
    }

    private void Start()
    {
        if (isRaining == true)
        {
            Debug.Log(message);
        }
        else if (isTraffic == true)
        {
            Debug.Log(message);
        }
        else
        {
            Debug.Log(message2);
        }


        if (isRaining && isTraffic)
        {
            Debug.Log(message3);
        }

    }
}
