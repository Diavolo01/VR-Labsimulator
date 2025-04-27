using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Osmosis : MonoBehaviour
{
    public float maxlevel;
    //public float waitTime;
    public float growFactor = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Scale());
    }

    /*IEnumerator Scale()
    {
        float timer = 0;


        while (maxlevel > transform.lossyScale.x)
        {
            timer += Time.deltaTime;
            transform.localScale += new Vector3(0, 1, 0) * Time.deltaTime * growFactor;
            yield return null;
        }

    }*/

    private void Update()
    {
        transform.localScale += new Vector3(0, growFactor * Time.deltaTime, 0);

        // Clamp the y scale to ensure it stays between 0 and maxLevel
        transform.localScale = new Vector3(
            transform.localScale.x,
            Mathf.Clamp(transform.localScale.y, 0.0f, maxlevel),
            transform.localScale.z
        );
    }
}
