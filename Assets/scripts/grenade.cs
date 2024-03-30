using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenade : Sounds
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private float delay = 3;
    public GameObject explosionprefab;
    private void OnCollisionEnter(Collision collision)
    {
        PlaySound(sounds[1], 0.3f);
        Invoke("Explosion", delay);
    }
    private void Explosion()
    {
        PlaySound(sounds[0],0.7f,destroyed:true);
        Destroy(gameObject);
        var explosion = Instantiate(explosionprefab);
        explosion.transform.position = transform.position;
    }
}
