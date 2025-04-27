using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class tapwater : MonoBehaviour
{
    public GameObject waterPrefab; // Prefab of water droplets
    public Transform waterSpawnPoint; // Point where water will be generated
    public float waterGenerationRate = 0.1f; // Rate at which water will be generated (per second)

    private XRGrabInteractable grabInteractable; // Reference to XRGrabInteractable component
    private bool isFilling = false;

    void Start()
    {
        // Get reference to XRGrabInteractable component
        grabInteractable = GetComponent<XRGrabInteractable>();

        // Subscribe to grab events
        grabInteractable.selectEntered.AddListener(StartFilling);
        grabInteractable.selectExited.AddListener(StopFilling);
    }

    void Update()
    {
        if (isFilling)
        {
            GenerateWater();
        }
    }

    void StartFilling(SelectEnterEventArgs args)
    {
        isFilling = true;
    }

    void StopFilling(SelectExitEventArgs args)
    {
        isFilling = false;
    }

    void GenerateWater()
    {
        GameObject water = Instantiate(waterPrefab, waterSpawnPoint.position, Quaternion.identity);
        Destroy(water, 2f); // Destroy water after 2 seconds
    }
}
