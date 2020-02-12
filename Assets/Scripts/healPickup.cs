﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider collider)
    {
        Health health = collider.GetComponent<Health>();
        if (health != null && collider.tag == "Player")
        {
            GetComponent<MeshRenderer>().enabled = false;
            Destroy(gameObject);    
            Debug.Log("Pick Up");
            health.Damage(-50);
        }

    }


}
