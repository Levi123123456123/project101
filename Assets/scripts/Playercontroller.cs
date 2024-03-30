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
    public float smeedorig;
    public float smeed2;
    public float stamina = 100;
    public float timeout = 0;
    public Animator anim;
    public GameObject body;
    void Start()
    {
        charcontrl = GetComponent<CharacterController>();
        smeedorig=smeed;
        smeed2=smeed*2;
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
        if (Input.GetKeyDown(KeyCode.Space) && charcontrl.isGrounded)
            {
                Fallvelocity = -jmfrce;
            }
        if (Input.GetKey(KeyCode.LeftShift)&&stamina>=10&&timeout<=0)
        {
            smeed =smeed2;
            stamina-=20*Time.deltaTime;
        }
        else
        {
            smeed=smeedorig;
            stamina+=15*Time.deltaTime;
            stamina = Mathf.Clamp(stamina, 0, 100);
            timeout-=Time.deltaTime;
        }
        if (stamina<=11)
        {
            timeout=5;

        }
    }
    void FixedUpdate()
    {
        charcontrl.Move(vectr*Time.fixedDeltaTime*smeed);
        Fallvelocity += gravity * Time.fixedDeltaTime;
        charcontrl.Move(Vector3.down*Fallvelocity*Time.fixedDeltaTime);
        if (charcontrl.isGrounded)
            {
                Fallvelocity = 0;
            }
    }
}
