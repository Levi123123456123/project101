using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_rotation : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform HUILGLOBALTransform;
    public float rotationspeed;
    public float minangle;
    public float maxangle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0,transform.localEulerAngles.y + Time.deltaTime*rotationspeed*Input.GetAxis("Mouse X"),0);

        var newangleX = HUILGLOBALTransform.localEulerAngles.x - Time.deltaTime * rotationspeed * Input.GetAxis("Mouse Y");
        if (newangleX >180)
            newangleX -=360;
        newangleX = Mathf.Clamp(newangleX,-minangle,maxangle);
        HUILGLOBALTransform.localEulerAngles = new Vector3(newangleX,0,0);
    }
}
