using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : Sounds
{
    public float maxvalue;
    public float value = 100;
    public RectTransform valueRectTransform;
    public GameObject UI;
    public GameObject end;
    public GameObject vin;
    public GameObject help;
    public float dead = 0;
    public float win;
    public float coins;
    public GameObject fireball;
    public 
    void Start()
    {
        maxvalue = value;
        newvalue();
        win = GameObject.Find("waveinvoker").GetComponent<waves>().win;
        Invoke("update10sec",10);
    }

    // Update is called once per frame
    public void Update123(float damage)
    {
        if (dead == 0)
        {
            value -= damage;
            if(value <= 0)
            {
                value = 0;
                pded();
            }
            newvalue();
        }
    }
    private void newvalue()
    {
        valueRectTransform.anchorMax = new Vector2(value/maxvalue, 1);
    }
    public void addhealth(float amount)
    {
        value += amount;
        value = Mathf.Clamp(value, 0, maxvalue);
        newvalue();
    }
    private void pded()
    {
        dead = 1;
        PlaySound(sounds[0]);
        UI.SetActive(false);
        end.SetActive(true);
        GetComponent<Playercontroller>().enabled = false;
        GetComponent<Camera_rotation>().enabled = false;
        GetComponent<firesourse>().enabled = false;
        GetComponent<Shooter>().enabled = false;
        GetComponent<Grenadelauncher>().enabled = false;
    }
    void Update()
    {
        if(win==1)
        {
            pded();
            vin.SetActive(true);
        }
        if(Input.GetKey(KeyCode.E) && coins >= 10)
            {
                value += 30;
                value = Mathf.Clamp(value, 0, maxvalue);
                coins -= 10;
                newvalue();
            }
        if(Input.GetKey(KeyCode.Q) && coins >= 10)
            {
                fireball.GetComponent<fireball>().damage+=10;
                coins -= 10;
            }
        if(Input.GetKey(KeyCode.F))
        {
            help.SetActive(false);
        }
    }
    void update10sec()
    {
        win = GameObject.Find("waveinvoker").GetComponent<waves>().win;
        Invoke("update10sec",10);
    }
}

