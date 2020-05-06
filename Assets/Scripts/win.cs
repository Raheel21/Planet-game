using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class win : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)//trigger event for colliding with player
    {
        if (other.gameObject.tag == "Player")//if statement for if colliding with object with tag player
        {

            Cursor.lockState = CursorLockMode.None; //Make the cursor not locked 
            Cursor.visible = true; //Make the cursor visible
            Debug.Log("You Won"); // Print log message to console that say Player won  
            SceneManager.LoadScene("Win Scene");//Use scene manager to load win scene 

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
