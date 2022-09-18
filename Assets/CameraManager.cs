using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public UIManager uIManager;

    private bool isMoving;

    public int maxID;
    public int minID;
    public int scenarioID;
    public enum CurrentScenario {kitchen2, kitchen1, farm1, trees1, farm2, trees2 }
    public CurrentScenario currentScenario;
    void Start()
    {
        scenarioID = 0;
        SetScenario();
    }

    public void MoveRight()
    {
        if (!isMoving && scenarioID >= minID && scenarioID < maxID)
        {
            isMoving = true;
            LeanTween.moveX(gameObject, gameObject.transform.localPosition.x + 6f, 0.5f).setEase(LeanTweenType.easeOutQuad).setOnComplete(FinishedMove);
            scenarioID++;
            SetScenario();
        }
    }

    public void MoveLeft()
    {
        if (!isMoving && scenarioID > minID && scenarioID <= maxID)
        {
            isMoving = true;
            LeanTween.moveX(gameObject, gameObject.transform.localPosition.x - 6f, 0.5f).setEase(LeanTweenType.easeOutQuad).setOnComplete(FinishedMove);
            scenarioID--;
            SetScenario();
        }
    }
    void FinishedMove() 
    {
        isMoving = false;
    }

    void SetScenario()
    {
        switch (scenarioID)
        {
            case -2:
                currentScenario = CurrentScenario.kitchen2;
                break;

            case -1:
                currentScenario = CurrentScenario.kitchen1;
                uIManager.Hide1SecButton();
                break;

            case 0:
                currentScenario = CurrentScenario.farm1;
                uIManager.Show1SecButton();
                break;

            case 1:
                currentScenario = CurrentScenario.trees1;
                break;

            case 2:
                currentScenario = CurrentScenario.farm2;
                break;

            case 3:
                currentScenario = CurrentScenario.trees2;
                break;
        }
    }
}
