using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MergeGlassStand : MonoBehaviour
{
    private string MergeStandGlass;

    int ID;
    public Toggle toggle1;
    public GameObject merged_object;

    // Start is called before the first frame update
    void Start()
    {
        tag = "MergeStandGlass";
        ID = GetInstanceID();
        toggle1.GetComponent<Toggle>().isOn = false;
    }

    private void OnCollisionEnter(Collision bol)
    {
        if (bol.gameObject.CompareTag("MergeStandGlass"))
        {

            if (ID < bol.gameObject.GetComponent<MergeGlassStand>().ID)
            {
                return;
            }

            Debug.Log("Merge" + gameObject.name);
            Destroy(bol.gameObject);
            Destroy(gameObject);
            toggle1.GetComponent<Toggle>().isOn = true;
            //GameObject obj = Instantiate(merged_object, transform.position = new Vector3(18.4659996f, 1.31110001f, -1.58599997f), Quaternion.Euler(0, 0, 0));
            merged_object.transform.position = new Vector3(18.4890003f, 1.31110001f, -1.375f); 

        }

        // Update is called once per frame

    }
}
