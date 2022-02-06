using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public string myName = "Canberk";
    public int age = 29;
    public float mySpeed = 4.5f;
    public int health = 100;
    public int score = 100;
    public bool hasKey = false;
    public int ammo = 1000; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is: " + myName);
        Debug.Log("My age is: " + age);
        Debug.Log("My speed is: " + mySpeed);
        Debug.Log("My health is: " + health);
        Debug.Log("My score is: " + score);
        Debug.Log(hasKey);
        Debug.Log("Ammo: " + ammo);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
