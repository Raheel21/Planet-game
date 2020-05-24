using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnHideScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.unhide)
        {
            transform.GetChild(0).gameObject.SetActive(true);

        }

        else

        { 

            transform.GetChild(0).gameObject.SetActive(false);
           


        }
    }
}
