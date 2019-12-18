using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    [SerializeField] GameObject thingToSpawn;
    [SerializeField] float delayBetweenSpawns = 2.0f;
    [SerializeField] float timeofNextSpawn = 1f; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Time.time >= timeofNextSpawn)
        {
            Instantiate(thingToSpawn, transform.position, Quaternion.identity);
            timeofNextSpawn = Time.time + delayBetweenSpawns;


        }

















    }
}
