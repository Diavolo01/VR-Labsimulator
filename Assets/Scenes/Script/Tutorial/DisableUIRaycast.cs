using UnityEngine;
using UnityEngine.UI;

public class DisableUIRaycast : MonoBehaviour
{
    public LayerMask layerMask;

    void Start()
    {
        int uiLayer = LayerMask.NameToLayer("UI");
        layerMask = ~(1 << uiLayer);
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, layerMask))
        {
        }
    }
}
