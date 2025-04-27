using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWaterParticle : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject, 1f);
    }
}
