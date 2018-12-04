using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteract : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
        if (Input.GetKeyDown(KeyCode.E))
        {

            Ray mouseRay = GetComponentInChildren<Camera>().ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitInfo; 
            if (Physics.Raycast(mouseRay, out hitInfo))
            {

                Dooropen door = hitInfo.transform.GetComponent<Dooropen>();
                if (door)
                {

                    door.enabled = true; 
                }

            }

        }
	}























}
