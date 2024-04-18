using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;
    private const float speed = 15f;
    //private const float mouse_sens = 100f;
    //private float x_Rotation = 0f;


    void Update()
    {
        //float mouse_x = Input.GetAxis("Mouse X") * mouse_sens * Time.deltaTime;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        //transform.Rotate(Vector3.up * mouse_x);
        characterController.Move(move * speed * Time.deltaTime);
    }
}
