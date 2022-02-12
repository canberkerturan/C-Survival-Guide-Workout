using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizGrades : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
    public int d;
    public int e;
    public int result;
    // Start is called before the first frame update
    void Start()
    {
        a = Random.Range(0, 100);
        b = Random.Range(0, 100);
        c = Random.Range(0, 100);
        d = Random.Range(0, 100);
        e = Random.Range(0, 100);
        result = (a + b + c + d + e) / 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (result >= 90)
        {
            Debug.Log("A");
        }
        else if (result >= 80 && result <= 90)
        {
            Debug.Log("B");
        }
        else if (result >= 70 && result <= 80)
        {
            Debug.Log("C");
        }
        else 
        {
            Debug.Log("F");
        }
    } 
    
}
