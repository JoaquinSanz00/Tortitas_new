using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LeanTweenHelper
{
    public static void Bounce(GameObject tweenObj, float scaleMultiplier, float tweenTime)
    {
        LeanTween.scale(tweenObj, tweenObj.transform.localScale * scaleMultiplier, tweenTime).setLoopPingPong(1);
    }
}
