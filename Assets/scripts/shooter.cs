using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public fireball prefab;
    public Transform fireballSourseTransform;
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(prefab,fireballSourseTransform.position,fireballSourseTransform.rotation);
        }
    }
}
