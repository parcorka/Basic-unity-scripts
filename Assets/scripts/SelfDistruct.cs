using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDistruct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //Destroy(this.gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
