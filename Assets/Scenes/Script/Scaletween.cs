using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaletween : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClose()
    {
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.5f).setOnComplete(DestroyMe);
    }
    void DestroyMe()
    {
        Destroy(gameObject);
    }
}
