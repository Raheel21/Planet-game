using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    [SerializeField] int maximumHealth = 100;
    [SerializeField] int currentHealth = 100;

	// Use this for initialization
	void Start () {

        currentHealth = maximumHealth; 		

	}

    public bool IsDead { get { return currentHealth <= 0; } }

    public int GetHealth()
    {

        return currentHealth;

    }

    public int GetMaxHealth()
    {

        return maximumHealth;

    }

    public void Damage (int damageValue)
    {
        currentHealth -= damageValue;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Player Destroyed");


        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
