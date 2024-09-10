using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float mouse_sens = 150f;
    private float target_rotation_x = 0f;
    private float target_rotation_y = 0f;

    public float throwForce = 5;
    public GameObject pewpew;

    public GameObject impactEffect;

    private void OnLevelWasLoaded(int level)
    {
        if (level == 1)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    void Update()
    {
        float mouse_x = Input.GetAxis("Mouse X") * mouse_sens * Time.deltaTime;
        float mouse_y = Input.GetAxis("Mouse Y") * mouse_sens * Time.deltaTime;
        target_rotation_y += mouse_x;
        target_rotation_x -= mouse_y;
        target_rotation_x = Mathf.Clamp(target_rotation_x, -90f, 90f);

        transform.localRotation = Quaternion.Euler(target_rotation_x, target_rotation_y, 0f);
        player.Rotate(Vector3.up * mouse_x);

        /*if (Input.GetKey(KeyCode.Mouse0))
        {
            PewPew();
        }*/
        if (Input.GetKey(KeyCode.E))
        {
            shoot();
        }
    }

    private void shoot()
    {
        RaycastHit pow;
        Physics.Raycast(this.transform.position, this.transform.forward, out pow);
        //cam.Recoil();
        //enemyGUN en = pow.transform.GetComponent<enemyGUN>();
        //if (en != null) en.GetHit();
        //boom.Play();
        GameObject obj = Instantiate(impactEffect, pow.point, Quaternion.LookRotation(pow.normal));
        Destroy(obj, 1f);
    }

    /*private void PewPew()
    {
        GameObject projectile = (GameObject)Instantiate(pewpew, transform.position, this.transform.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.AddForce(throwForce * Vector3.forward, ForceMode.Impulse);
    }*/
}
