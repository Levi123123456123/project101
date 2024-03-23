using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    public float speed = 1;
    public float time = 30;
    public float damage = 10;
    private CharacterController controller;
    void Start()
    {
        Invoke("destroy", time);
    }
    void FixedUpdate()
    {
        transform.position += transform.forward * speed * Time.fixedDeltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        var enemyhealth = collision.gameObject.GetComponent<enemyhealth>();
        if (enemyhealth != null)
        {
            enemyhealth.value -=damage;
        }
        destroy();
    }
    private void destroy()
    {
        Destroy(gameObject);
    }
}
