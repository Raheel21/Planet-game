using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) //trigger event for colliding with player
    {
        if (other.gameObject.tag == "Player")   //if statement for if colliding with object with tag player
        {

            Destroy(other.gameObject); //Then Destroy that game object with player tag 
            Debug.Log("Player Destroyed"); // Print log message to console that say Player destroyed 

        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    
}
