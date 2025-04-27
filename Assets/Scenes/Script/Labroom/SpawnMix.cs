using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMix : MonoBehaviour
{
    public Transform spawnpiont;
    public GameObject objectToSpawn;

    private int spawncount = 0;
    //public float spawntime = 2;

    private void OnTriggerStay(Collider other)
    {
        if (spawncount <= 30)
        {
            Instantiate(objectToSpawn, spawnpiont.position, spawnpiont.rotation);
            spawncount++;
        }
            
    }
}
