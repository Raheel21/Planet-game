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

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            DontDestroyOnLoad(other.gameObject);
            SceneManager.LoadScene("Level"); 
            Debug.Log("Object Teleported");

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
