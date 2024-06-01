using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour {
    Animator anim;
    void Start() {
        anim = GetComponent<Animator>();
    }
    void Update() { 
        if (Input.GetKeyDown(KeyCode.E))
            anim.SetTrigger("JumpTrigger");
    }
}
