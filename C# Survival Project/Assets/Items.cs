using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    // Start is called before the first frame update
    public string itemName = "shotgun";
    // public string itemDescription = 
    public Sprite itemIcon = null; 
    public int itemStrength = 47;
    void Start()
    {
        Debug.Log(itemName);
        Debug.Log(itemIcon);
        Debug.Log(itemStrength);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
