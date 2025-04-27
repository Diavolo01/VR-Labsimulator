using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;
using UnityEngine.UI;

public class spawnwater : MonoBehaviour
{
    public Toggle toggle1;
    public GameObject waterCylinder;
    private int spawncount = 1;
    public Transform spawnpoint;
    public float maxLevel;
    public float growFactor;
    public float waitTime;
    public GameObject Bequer;

    public GameObject fakeStand;  // Reference to the fake stand
    public GameObject realStand;


    void Start()
    {
        toggle1.GetComponent<Toggle>().isOn = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "waterparticle")
        {
            if (spawncount == 1)
            {
                StartCoroutine(SpawnWaterCylinder());
                spawncount++;
                toggle1.GetComponent <Toggle>().isOn = true;

                Destroy(fakeStand);  // Destroy the fake stand
                realStand.transform.position = new Vector3(-0.912f, 1.3111f, 0.351f);
            }
        }
    }

    IEnumerator SpawnWaterCylinder()
    {
        GameObject water = Instantiate(waterCylinder, spawnpoint.position, spawnpoint.rotation);
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
}
