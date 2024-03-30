using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : Sounds
{
    public float value = 100;
    public GameObject player;
    public float cost = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(value <= 0)
        {
            PlaySound(sounds[0],0.7f,destroyed:true);
            player.GetComponent<playerhealth>().coins+=1*cost;
            Destroy(gameObject);
        }
    }
    public void Damage(float damage)
    {
        if (value != null)
        {
            value -=damage;
        }
    }
    
}
