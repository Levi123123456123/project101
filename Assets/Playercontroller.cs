using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    private float Fallvelocity = 1;
    public float gravity = 9.8F;
    private CharacterController charcontrl;
    public float jmfrce;
    public float smeed;
    private Vector3 vectr;
    void Start()
    {
        charcontrl = GetComponent<CharacterController>();
    }
     void Update()
    {
        vectr = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
            {
                vectr += transform.forward;
            }
        if(Input.GetKey(KeyCode.S))
            {
                vectr -= transform.forward;
            }
        if(Input.GetKey(KeyCode.D))
            {
                vectr += transform.right;
            }
        if(Input.GetKey(KeyCode.A))
            {
                vectr -= transform.right;
            }
        if (charcontrl.isGrounded)
            {
                Fallvelocity = 0;
            }
        if (Input.GetKeyDown(KeyCode.Space) && charcontrl.isGrounded)
            {
                Fallvelocity = - jmfrce;
            }
    }
    void FixedUpdate()
    {
        charcontrl.Move(vectr*Time.fixedDeltaTime*smeed);
        Fallvelocity += gravity * Time.fixedDeltaTime;
        charcontrl.Move(Vector3.down*Fallvelocity*Time.fixedDeltaTime);
    }
}
