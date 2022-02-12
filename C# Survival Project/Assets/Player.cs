using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int myPoint;

    public bool hasSaidMessage = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            
        {
            myPoint += 10;
            Debug.Log(myPoint); 
        }
        else if (myPoint >= 50 && hasSaidMessage == false)

        {
            Debug.Log("You are awesome!");
            hasSaidMessage = true;
        }   
    }


}
