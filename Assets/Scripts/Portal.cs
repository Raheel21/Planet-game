using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other) //trigger event for colliding with player
    {

        if (other.gameObject.tag == "Player") //if statement for if colliding with object with tag player
        {

            DontDestroyOnLoad(other.gameObject); //Do not destroy game object with tag player
            SceneManager.LoadScene("Level"); //Load scene from scene manager called Level
            Debug.Log("Player Teleported"); // Print log message to console that say Player Teleported 

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
