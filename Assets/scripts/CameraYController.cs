using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraYController : MonoBehaviour
{
    public Transform player;
    private const float mouse_sens = 100f;
    private float target_rotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouse_x = Input.GetAxis("Mouse X") * mouse_sens * Time.deltaTime;
        float mouse_y = Input.GetAxis("Mouse Y") * mouse_sens * Time.deltaTime;
        target_rotation -= mouse_y;
        target_rotation = Mathf.Clamp(target_rotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(target_rotation, 0f, 0f);
        player.Rotate(Vector3.up * mouse_x);
    }
}
