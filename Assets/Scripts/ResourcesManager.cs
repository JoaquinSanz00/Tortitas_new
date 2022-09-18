using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResourcesManager : MonoBehaviour
{
    public CameraManager cameraManager;

    public GameObject[] t1Crops;
    public GameObject[] t1Trees;

    public GameObject[] t2Crops;
    public GameObject[] t2Trees;

    public int wheatAmount;
    public TextMeshProUGUI wheatAmountText;

    public void SubstractOneSecond()
    {
        switch (cameraManager.scenarioID)
        {
            case 0:
                foreach (GameObject crop in t1Crops)
                {
                    if (crop.GetComponentInChildren<GrowingObject>().timeLeft > 0)
                    {
                        crop.GetComponentInChildren<GrowingObject>().timeLeft -= 1f;
                    }
                }
                break;

            case 1:
                foreach (GameObject crop in t1Trees)
                {
                    if (crop.GetComponentInChildren<GrowingObject>().timeLeft > 0)
                    {
                        crop.GetComponentInChildren<GrowingObject>().timeLeft -= 1f;
                    }
                }
                break;

            case 2:
                foreach (GameObject crop in t2Crops)
                {
                    if (crop.GetComponentInChildren<GrowingObject>().timeLeft > 0)
                    {
                        crop.GetComponentInChildren<GrowingObject>().timeLeft -= 1f;
                    }
                }
                break;

            case 3:
                foreach (GameObject crop in t2Trees)
                {
                    if (crop.GetComponentInChildren<GrowingObject>().timeLeft > 0)
                    {
                        crop.GetComponentInChildren<GrowingObject>().timeLeft -= 1f;
                    }
                }
                break;
        }
    }
}
