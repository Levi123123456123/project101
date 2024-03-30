using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstaid : MonoBehaviour
{
    // Start is called before the first frame update
    public float healval = 50;
    private void OnTriggerEnter(Collider other)
    {
        var playerhealth = other.gameObject.GetComponent<playerhealth>();
        if(playerhealth != null)
        {
            playerhealth.addhealth(healval);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
