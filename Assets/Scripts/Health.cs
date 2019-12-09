﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    [SerializeField] int maximumHealth = 100;
    int currentHealth = 0;

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

        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}