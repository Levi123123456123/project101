using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walkingsound : Sounds
{
    private CharacterController charactercontroller => GetComponent<CharacterController>(); 
    void Start()
    {
        Invoke("sound",0.5f);
    }
    void sound()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if(charactercontroller.isGrounded)
            {
                PlaySound(sounds[Random.Range(0,3)],1);
            }
        }
        Invoke("sound",0.5f);
    }
}
