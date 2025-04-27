using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillUpLiquid : MonoBehaviour
{
    public float maxlevel;
    public float waitTime;
    public float growFactor;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Scale());
    }

    IEnumerator Scale()
    {
        float timer = 0;


        while (maxlevel > transform.lossyScale.x)
        {
            timer += Time.deltaTime;
            transform.localScale += new Vector3(1, 0.5f, 1) * Time.deltaTime * growFactor;
            yield return null;
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
