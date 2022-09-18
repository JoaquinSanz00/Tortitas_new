using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropHarvest : MonoBehaviour
{
    public GameObject currentCrop;
    public ResourcesManager resourcesManager;

    void Start()
    {
        resourcesManager = FindObjectOfType<ResourcesManager>();
        currentCrop = gameObject.GetComponentInChildren<GrowingObject>().gameObject;
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (currentCrop.name == "Wheat_Crop" && currentCrop.GetComponent<GrowingObject>().mature)
        {
            resourcesManager.wheatAmount++;
            currentCrop.GetComponent<GrowingObject>().ResetGrowth();
        }
    }
}
