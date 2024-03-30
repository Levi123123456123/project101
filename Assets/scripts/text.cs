using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class text : MonoBehaviour
{
    public TMP_Text text1;
    public GameObject playerControl;

    private void Update()
    {
        text1.text = (playerControl.GetComponent<playerhealth>().coins).ToString();
    } 
}