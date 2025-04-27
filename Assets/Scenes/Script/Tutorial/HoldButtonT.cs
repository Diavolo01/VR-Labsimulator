using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class HoldButtonT : MonoBehaviour
{
    public Toggle toggle2;


    void Start()
    {
        toggle2.GetComponent<Toggle>().isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    
    }
