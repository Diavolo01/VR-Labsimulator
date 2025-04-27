using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class destroywhenmixtureadded : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject destroystand;
    //public GameObject realStand;
    public void ActivateScript()
    {

        Debug.Log("activated");
        Destroy(this.gameObject);
       
       // realStand.transform.position = new Vector3(-0.912f, 1.3111f, 0.351f);
    }

}
