using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MergeTube : MonoBehaviour
{
    private int ID;
    public Toggle toggle1;
    public GameObject merged_object;

    // Start is called before the first frame update
    void Start()
    {
        ID = GetInstanceID();
        toggle1.isOn = false;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("tubeTag") )
        {
            MergeTube otherTube = col.gameObject.GetComponent<MergeTube>();

            if (ID < otherTube.ID)
            {
                return;
            }

            Debug.Log("Merge" + gameObject.name);
            Debug.Log("Collision with: " + col.gameObject.name);
            Destroy(col.gameObject);
            Destroy(gameObject);
            toggle1.isOn = true;
            GameObject obj = Instantiate(merged_object, new Vector3(-0.521933138f, -0.305362821f, 0.9218418f), Quaternion.Euler(0, 0, 0));
        }
    }
}
