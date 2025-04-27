using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeWATER : MonoBehaviour
{
    // Start is called before the first frame update
    private string mergebequerandwater;

    int ID;

    public GameObject merged_object;

    // Start is called before the first frame update
    void Start()
    {
        tag = "mergebequerandwater";
        ID = GetInstanceID();
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("mergebequerandwater"))
        {

            if (ID < col.gameObject.GetComponent<MergeWATER>().ID)
            {
                return;
            }

            Debug.Log("Merge" + gameObject.name);
            Destroy(col.gameObject);
            Destroy(gameObject);

            GameObject obj = Instantiate(merged_object, transform.position = new Vector3(29.3388004f, 1.52900004f, -1.50769997f), Quaternion.Euler(0, 0, 0));

        }

        // Update is called once per frame

    }
}
