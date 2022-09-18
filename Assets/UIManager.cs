using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject oneSecButton;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Hide1SecButton()
    {
        LeanTween.moveY(oneSecButton, -250, 0.3f).setEase(LeanTweenType.easeOutQuad);
    }

    public void Show1SecButton()
    {
        LeanTween.moveY(oneSecButton, +250, 0.3f).setEase(LeanTweenType.easeOutQuad);
    }
}
