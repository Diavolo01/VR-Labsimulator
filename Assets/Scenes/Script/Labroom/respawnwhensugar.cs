using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;
using UnityEngine.UI;

public class resoawnwhensugar : MonoBehaviour
{
    public Toggle toggle1;
    public GameObject sugarwater;
    private int spawncount = 1;
    public Transform spawnpoint;
    public float maxLevel;
    public float growFactor;
    public float waitTime;
    public GameObject Bequer;
    private float deltime = 4f;
    public GameObject crossmark;

    void Start()
    {
        toggle1.GetComponent<Toggle>().isOn = false;
        crossmark.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "mixtureparticle")
        {
            if (spawncount == 1)
            {
                StartCoroutine(SpawnWaterCylinder());
                spawncount++;
                crossmark.SetActive(true);
                StartCoroutine(DelayedDestroy());
            }
        }
    }

    IEnumerator SpawnWaterCylinder()
    {
        GameObject water = Instantiate(sugarwater, spawnpoint.position, spawnpoint.rotation);
        FillUpLiquid fillUpScript = water.GetComponent<FillUpLiquid>();

        water.transform.parent = Bequer.transform;
        float timer = 0;

        while (fillUpScript.maxlevel > water.transform.lossyScale.x)
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
        GameObject wrongwater = GameObject.Find("sugar water(Clone)");
        Destroy(wrongwater);
        crossmark.SetActive(false);
        spawncount = 1;

    }


}
