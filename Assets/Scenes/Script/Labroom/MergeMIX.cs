using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeMIX : MonoBehaviour
{
    private string mixtureGlassandsheet;

    int ID;

    public GameObject merged_object;

    // Start is called before the first frame update
    void Start()
    {
        name = "mixtureGlassandsheet";
        ID = GetInstanceID();
    }

    private void OnCollisionEnter(Collision okok)
    {
        if (okok.gameObject.name== "mixtureGlassandsheet")
        {

            if (ID < okok.gameObject.GetComponent<MergeMIX>().ID)
            {
                return;
            }

            Debug.Log("Merge" + gameObject.name);
            Destroy(okok.gameObject);
            Destroy(gameObject);

            GameObject obj = Instantiate(merged_object, transform.position = new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));

        }

        // Update is called once per frame

    }
}
