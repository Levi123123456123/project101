using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firesourse : MonoBehaviour
{
    public Transform targetpos;
    public Camera cameralink;
    public float distancetosky;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        var ray = cameralink.ViewportPointToRay(new Vector3(0.45f,0.4f,0));
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            targetpos.position = hit.point;
        }
        else
        {
            targetpos.position = ray.GetPoint(distancetosky);
        }
        transform.LookAt(targetpos.position);
    }
}
