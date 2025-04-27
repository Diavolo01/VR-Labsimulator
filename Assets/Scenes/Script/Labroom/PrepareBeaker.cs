using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrepareBeaker : MonoBehaviour
{
    public GameObject Baseplate;
    public Toggle toggle1;

    void Start()
    {
        toggle1.GetComponent<Toggle>().isOn = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Baseplate)
        {
            toggle1.GetComponent<Toggle>().isOn = true;
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == Baseplate)
        {
            toggle1 .GetComponent<Toggle>().isOn = false;
        }
    }
}
