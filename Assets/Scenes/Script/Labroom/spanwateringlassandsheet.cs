using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spanwateringlassandsheet : MonoBehaviour
{
    public Toggle toggle1;
    public GameObject mixCylinder;
    private int spawncount = 1;
    public Transform spawnpoint;
    public float maxLevel;
    public float growFactor;
    public float waitTime;
    public GameObject Glass;
    private float deltime = 4f;
    public GameObject crossmark;

    void Start()
    {
        toggle1.GetComponent<Toggle>().isOn = false;
        crossmark.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "waterparticle")
        {
            if (spawncount == 1)
            {
                StartCoroutine(SpawnMixCylinder());
                spawncount++;
                crossmark.SetActive(true);
                StartCoroutine(DelayedDestroy());
            }
        }
    }

    IEnumerator SpawnMixCylinder()
    {
        GameObject sugar = Instantiate(mixCylinder, spawnpoint.position, spawnpoint.rotation);
        FillUpLiquid fillUpScript = sugar.GetComponent<FillUpLiquid>();

        sugar.transform.parent = Glass.transform;
        float timer = 0;

        while (fillUpScript.maxlevel > sugar.transform.lossyScale.x)
        {
            timer += Time.deltaTime;
            fillUpScript.maxlevel = maxLevel;
            transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
            fillUpScript.waitTime = waitTime;
            yield return null;
        }
    }


    IEnumerator DelayedDestroy()
    {
        yield return new WaitForSeconds(deltime);

        GameObject wrongwater = GameObject.Find("waterglass(Clone)");
        

        crossmark.SetActive(false);
        Destroy(wrongwater);
        spawncount = 1;

    }
}
