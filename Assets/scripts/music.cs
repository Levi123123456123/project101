using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour

{
    // Start is called before the first frame update
    public float enabled = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.G))
        {
            if(enabled == 1)
            {
                enabled = 0;
                GetComponent<AudioSource>().enabled = false;
            }
            else
            {
                enabled = 1;
                GetComponent<AudioSource>().enabled = true;
            }
        }
    }
}
