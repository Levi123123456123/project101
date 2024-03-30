using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    public float damage = 50;
    public float maxsize = 5;
    public float speed = 5;
    void Update()
    {
        transform.localScale += Vector3.one * Time.deltaTime * speed;
        if (transform.localScale.x > maxsize)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        var playerhealth = other.GetComponent<playerhealth>();
        if (playerhealth != null)
        {
            playerhealth.Update123(damage);
        }
        var enemyhealth = other.GetComponent<enemyhealth>();
        if (enemyhealth != null)
        {
            enemyhealth.Damage(damage);
        }
    }
}
