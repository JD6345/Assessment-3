using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_pMovement : MonoBehaviour
{
    public CharacterController controller;
    [SerializeField] private float speed = 3.5f; //Base movement speed of the player

    [SerializeField] private float gravity = -15f; //value of the gravity's strength 
    Vector3 velocity;
    public Transform groundCheck; //referencing 
    [SerializeField] private float groundDistance = 0.5f; //Distance between ground and player
    public LayerMask groundMask; //Ensuring the player model doesnt effect the ground check
    [SerializeField] private bool isGrounded;

    [SerializeField] private float jumpHeight = 0.75f; //How high the player will jump

    public bool isSprinting = false; //Used to change between the two speed values of 'speed' and 'sprintingSpeed'
    [SerializeField] private float sprintingSpeed = 8f; //Value for how much faster sprinting will be 
    
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical"); //^Getting inputs for W,A,S,D
        
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime); //^How the player is able to move

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime); //^How gravity will affect the player

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //Checking for whether the player is grounded or not
        if(isGrounded && velocity.y < 0) 
        {
            velocity.y = -2f;
        }
        if(Input.GetButtonDown("Jump") && isGrounded) //When the player is grounded and the jump input is pressed, the player will jump
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        if (Input.GetKey(KeyCode.LeftShift)) //When the input (Lshift) is being pressed isSprinting will be activated
        {
            isSprinting = true;
        }
        else 
        {
            isSprinting = false;
        }

        if (isSprinting == true) //When isSprinting is activated the speed of the player will be increased and therefore be sprinting 
        {
            speed = sprintingSpeed; //speed will change into the sprinting speed value which has a higher value, making the player move faster when holding Lshift
        }
        else 
        {
            speed = 3.5f; //When isSprinting is false/returns to false the speed value will return to its orginal value
        } 
    }
}
