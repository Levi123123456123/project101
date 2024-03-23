using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    public float maxvalue;
    public float value = 100;
    public RectTransform valueRectTransform;
    public GameObject UI;
    public GameObject end;
    void Start()
    {
        maxvalue = value;
    }

    // Update is called once per frame
    public void Update123(float damage)
    {
        value -= damage;
        if(value <= 0)
        {
            pded();
        }
        valueRectTransform.anchorMax = new Vector2(value/maxvalue, 1);
    }
    private void pded()
    {
        UI.SetActive(false);
        end.SetActive(true);
        GetComponent<Playercontroller>().enabled = false;
        GetComponent<Camera_rotation>().enabled = false;
        GetComponent<firesourse>().enabled = false;
    }
}

