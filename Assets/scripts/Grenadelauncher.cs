using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Grenadelauncher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    public Rigidbody grenadePrefab;
    public Transform grenadeSourseTransform;
    public float force = 500;
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            var grenade = Instantiate(grenadePrefab);
            grenade.transform.position = grenadeSourseTransform.position;
            grenade.GetComponent<Rigidbody>().AddForce(grenadeSourseTransform.forward * force);
        }
    }
}
