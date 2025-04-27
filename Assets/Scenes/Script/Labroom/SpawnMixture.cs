using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpawnMixture : MonoBehaviour
{
    public Toggle toggle1;
    public GameObject mixCylinder;
    private int spawncount = 1;
    public Transform spawnpoint;
    public float maxLevel;
    public float growFactor;
    public float waitTime;
    public GameObject Glass;

    //public destroywhenmixtureadded script2;
    public GameObject destorywaterstand;
    public GameObject realwaterstand;


    void Start()
    {
        toggle1.GetComponent<Toggle>().isOn = false;

        /*if (script2 == null)
        {
            script2 = GetComponent<destroywhenmixtureadded>();
        }*/
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "mixtureparticle")
        {
            if (spawncount == 1)
            {
                StartCoroutine(SpawnMixCylinder());
                spawncount++;
                toggle1.GetComponent<Toggle>().isOn = true;
                
                    Debug.Log("destroyed");
                    Destroy(destorywaterstand);
                realwaterstand.transform.position = new Vector3(18.4890003f, 1.31110001f, -1.375f);
               
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
}
