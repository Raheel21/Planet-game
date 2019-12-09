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

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            Destroy(other.gameObject);
            Debug.Log("Object Destroyed"); 

        }

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    
}
