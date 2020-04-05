using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
   //Both my max health and current health are serialized so that they are visible in the unity inspector 
   //And i can adjust both my health status from within the Unity inspector without having to change it within my script    
    [SerializeField] int maximumHealth = 100; 
    [SerializeField] int currentHealth = 100;

    // Use this for initialization
    void Start()
    {
        currentHealth = maximumHealth; //This is setting the current health to the max health 
    }

    //Below i use properties to get back my players current and max health and check the if the health is less than or equal to 0
    public bool IsDead { get { return currentHealth <= 0; } } 

    //Below would be for getting back the players current health
    public int GetHealth()
    {
        return currentHealth;
    }

    //Below would be used to get back the players max health 
    public int GetMaxHealth()
    {
        return maximumHealth;
    }

    //Below is my damage function which is public so it can be used by my other scripts
    //Allows integer type as damage value which is then taken away from the players current health
    //If player current health is equal to or below 0 the the cursor is unlocked and visible along with the player game object gets destroyed
    //Along with a message gets printed to know the player has been destroyed and then the lose scene is loaded
    public void Damage(int damageValue)
    {
        currentHealth -= damageValue;
        if (currentHealth <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Destroy(gameObject);
            Debug.Log("Player Destroyed");
            SceneManager.LoadScene("Lose Scene");            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth > 100)//if player health is more than 100
        {
            currentHealth = 100; //Health is set at 100 so player cannot have more then 100 health  
        }
    }
}

