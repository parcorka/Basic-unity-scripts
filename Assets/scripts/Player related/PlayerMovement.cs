using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;

    public float speed = 10f;
    private float x;
    private float z;

    Vector3 move;
    Vector3 velocity;

    public float jumpForce = 100f;
    //public float air_modifier;
    //public LayerMask whatIsGround;
    private bool grounded;
    public float gravity = -9.8f;


    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        //readyToJump = true;
    }
    void Update()
    {
        grounded = characterController.isGrounded;
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            //Debug.Log("Jump?");
            Jump();
        }
    }
    private void FixedUpdate()
    {
        move = transform.right * x + transform.forward * z;

        characterController.Move(move * speed * Time.deltaTime);
        if (!grounded) // in air
        {
            velocity.y += gravity + Time.deltaTime;
            characterController.Move(velocity * Time.deltaTime / 2);
        }
    }

    private void Jump()
    {
        //Debug.Log("Jump!");
        velocity.y = jumpForce;
    }
}
