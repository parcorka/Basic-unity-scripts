using NUnit.Framework.Internal;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class godcubescript : MonoBehaviour
{
    public GameObject spawn;
    public float rand_x;
    public float rand_z;
    private double cooldown = -1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("(START)  rand_x = " + rand_x + "   rand_z = " + rand_z);
    }

    // Update is called once per frame
    void Update()
    {
        //Cooldown
        if (cooldown < Time.time)
        {
            Randomize();
            Spawn();
            cooldown = Time.time + 1.5; // cooldown is 1.5 sec
        }
        
    }

    void Spawn()
    {
        Debug.Log("(SPAWN)  rand_x = " + rand_x + "   rand_z = " + rand_z);
        Vector3 vec = new Vector3(rand_x, this.transform.position.y, rand_z);
        spawn.transform.position = vec;
        Instantiate(spawn);
    }

    void Randomize()
    {
        rand_x = Random.Range(-5, 5);
        rand_z = Random.Range(-5, 5);
    }
}
