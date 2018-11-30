using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthpickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter(Collider other)
    {
        print("pick up");
        if (GetComponent<Collider>().CompareTag("Player"))
        {

            Health health = GetComponent<Collider>().gameObject.GetComponent<Health>();
            if(health != null)
            {
                health.Damage(-50); 
            }

        }
        
    }
}
