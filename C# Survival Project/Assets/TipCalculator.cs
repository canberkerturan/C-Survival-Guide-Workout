using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    float a = 40;
    float b = 0.20f;
    float result; 
    // Start is called before the first frame update
    void Start()
    {
        result = a * b + a;  
        Debug.Log("Your bill is: " + a + "and your tip amount is: " + b +  "so you owe: " + result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
