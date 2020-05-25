using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    CharacterController charController;

    [SerializeField] float jumpSpeed = 30.0f;
    [SerializeField] float gravity = 1.0f;
    float yVelocity = 0.0f;

    [SerializeField] float moveSpeed = 30.0f;
    [SerializeField] float sprintSpeed = 2.0f;
    public float h;
    public float v;

    // Use this for initialization
    void Start()
    {

        charController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        h = Input.GetAxis ("Horizontal");
        v = Input.GetAxis ("Vertical");

        Vector3 direction = new Vector3(h, 0, v);
        Vector3 velocity = direction*moveSpeed;
     
        if(Input.GetKey("joystick button 6"))
        {
            sprintSpeed = 10;
        }

        else
        {

            sprintSpeed = 5; 
        }

        if (Input.GetKey("left shift"))
        {
            sprintSpeed = 10;
        }
        else
        {
            sprintSpeed = 5;

        }








        if (charController.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                
                yVelocity = jumpSpeed;
            }
        }
        else
        {

            yVelocity -= gravity;

        }

        velocity.y = yVelocity;

        velocity = transform.TransformDirection(velocity);

        charController.Move(velocity * sprintSpeed * Time.deltaTime);

    }
}
