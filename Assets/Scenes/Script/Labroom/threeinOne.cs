using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class threeinOne : MonoBehaviour
{
    private int ID;
    public Toggle toggle1;
    public GameObject merged_object2;

    // Start is called before the first frame update
    void Start()
    {
        ID = GetInstanceID();
        toggle1.isOn = false;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("allinone") && col.gameObject.GetComponent<threeinOne>() != null)
        {
            threeinOne otherObject = col.gameObject.GetComponent<threeinOne>();

            if (ID < otherObject.ID)
            {
                return;
            }

            Debug.Log("Merge " + gameObject.name);
            Debug.Log("Collision with: " + col.gameObject.name);
            Destroy(col.gameObject);
            Destroy(gameObject);
            toggle1.isOn = true;
            GameObject obj = Instantiate(merged_object2, new Vector3(-0.261000007f, -0.579999983f, 0.462000012f), Quaternion.Euler(0, 0, 0));
        }
    }
}
