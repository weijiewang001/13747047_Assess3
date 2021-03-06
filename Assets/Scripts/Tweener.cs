using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Tweener : MonoBehaviour
{
    private Tween activeTween;
    private float distance;

    void Update()
    {

        

        if (activeTween != null && activeTween.Target != null)
        {
            distance = Vector3.Distance(activeTween.Target.position, activeTween.EndPos);
            if (distance > 0.1f)
            {
                float timeFraction = (Time.time - activeTween.StartTime) / activeTween.Duration;
                activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, timeFraction);
            }
            else
            {
                activeTween.Target.position = activeTween.EndPos;
                activeTween = null;
            }
        }
    }
    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {

        if (activeTween == null)
        {
            activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        }
        else
        {
            activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        }
    }
}
