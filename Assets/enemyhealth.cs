﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    public float value = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
