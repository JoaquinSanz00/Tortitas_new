using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingObject : MonoBehaviour
{
    public GameObject[] cropStages;
    public ResourcesManager resourcesManager;

    public float totalCropTime;

    public float timeForSprout;
    public bool sprout;

    public float timeForMidstage;
    public bool midStage;

    public float timeLeft;
    public bool mature;

    public bool timerOn = false;

    void Start()
    {
        timerOn = true;
    }

    void Update()
    {
        if (timerOn)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                GrowTimer(timeLeft);
            }
            else
            {
                Debug.Log("Time is UP!");
                timeLeft = 0;
                timerOn = false;
            }
        }

        Grow();
    }

    void GrowTimer(float currentTime)
    {
        currentTime += 1;
    }

    void Grow()
    {
        if (timeLeft < timeForSprout && !sprout)
        {
            cropStages[0].SetActive(true);
            sprout = true;
            LeanTweenHelper.Bounce(cropStages[0], 1.2f, 0.1f);
        }

        if (timeLeft < timeForMidstage && !midStage)
        {
            cropStages[0].SetActive(false);
            cropStages[1].SetActive(true);
            midStage = true;
            LeanTweenHelper.Bounce(cropStages[1], 1.2f, 0.1f);
        }

        if (timeLeft == 0 && !mature)
        {
            cropStages[1].SetActive(false);
            cropStages[2].SetActive(true);
            mature = true;
            LeanTweenHelper.Bounce(cropStages[2], 1.2f, 0.1f);
        }
    }

    public void ResetGrowth()
    {
        cropStages[0].SetActive(false);
        cropStages[1].SetActive(false);
        cropStages[2].SetActive(false);

        sprout = false;
        midStage = false;
        mature = false;

        timerOn = true;
        timeLeft = totalCropTime;

        resourcesManager.wheatAmountText.text = ($"{resourcesManager.wheatAmount}");
    }
}
