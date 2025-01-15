using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCurveDemo : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0,1)]
    public float t;
   
    void Start()
    {
        
    }

    void Update()
    {
        t += Time.deltaTime;
        if(t > 1)
        {
            t = 0;
        }

        transform.localScale = Vector2.one * curve.Evaluate(t);
    }
}
