using UnityEngine;

public class Donguler : MonoBehaviour
{
    private int maxValue = 100;
    private int count = 0;

    void Start()
    {
        for (int i = 0; i < maxValue; i++)
        {
            if (i % 2 == 0)
            {
                count++;
                //Debug.Log(count);
            }


             Debug.Log(i);
        }
        
        
            //Debug.Log(count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
