using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : Sounds
{
    public float speed = 1;
    public float time = 30;
    public float damage = 15;
    private CharacterController controller;
    void Start()
    {
        PlaySound(sounds[0], 0.1f,destroyed: true);
        Invoke("destroy", time);
    }
    void FixedUpdate()
    {
        transform.position += transform.forward * speed * Time.fixedDeltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        PlaySound(sounds[1], 0.1f);
        var enemyhealth = collision.gameObject.GetComponent<enemyhealth>();
        enemyhealth.Damage(damage);
        destroy();
    }
    private void destroy()
    {
        Destroy(gameObject);
    }
}
