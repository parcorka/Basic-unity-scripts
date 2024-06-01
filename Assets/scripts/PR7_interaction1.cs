using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PR7_interaction1 : MonoBehaviour
{
    private Renderer RendererProp;
    private Rigidbody phisicbody;
    private Vector3 MouseOffset;
    private float MouseZCoord;

    private void Start()
    {
        RendererProp = GetComponent<Renderer>();
        phisicbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (UnityEngine.Input.GetKeyDown(KeyCode.Q) && RendererProp.material.color == Color.yellow)
        {
            phisicbody.AddForce(0, 300, 0);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            RendererProp.material.color = Color.yellow;
            /*if (UnityEngine.Input.GetKeyDown(KeyCode.Q))
            {
                phisicbody.AddForce(0, 300, 0);
            }
            if (UnityEngine.Input.GetKeyDown(KeyCode.E))
            {
            }*/
        } 
    }
    private void OnTriggerExit(Collider other)
    {
        RendererProp.material.color = Color.blue;
    }

    /*private void OnMouseEnter()
    {
        Debug.Log(name);
        Debug.Log(transform.position);
    }*/

    void OnMouseDown()
    {
        MouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        MouseOffset = gameObject.transform.position - GetMousePosition();
    }
    private Vector3 GetMousePosition()
    {
        Vector3 mousePoint = UnityEngine.Input.mousePosition;
        mousePoint.z = MouseZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMousePosition() + MouseOffset;
    }
}
