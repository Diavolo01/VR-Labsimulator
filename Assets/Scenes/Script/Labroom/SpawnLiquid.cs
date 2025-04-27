using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLiquid : MonoBehaviour
{
    public Transform spawnpiont;
    public GameObject objectToSpawn;

    private int spawncount = 0;
    //public float spawntime = 2;
    
    private void OnCollisionStay(Collision collision)
    {
        if(spawncount <= 28)
        Instantiate(objectToSpawn, spawnpiont.position, spawnpiont.rotation);
        spawncount++;
    }

}
