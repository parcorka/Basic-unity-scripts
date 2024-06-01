using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioSource SoundEff;
    private void OnCollisionEnter(Collision collision)
    {
        SoundEff.Play();
    }
}
