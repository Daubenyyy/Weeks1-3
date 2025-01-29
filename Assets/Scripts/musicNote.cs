using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicNote : MonoBehaviour
{
    //get animation curve
    public AnimationCurve grow;

    //set curve range
    [Range(0,1)]
    public float time; //varible for the curve

    public AnimationCurve move;

    [Range(0, 1)]
    public float t;

    public Transform start;
    public Transform end;

    void Start()
    {
        
    }

    void Update()
    {
        noteGrow();
        movement();
    }

    void noteGrow()
    {
        //checks if time is still within range
        if (time < 1)
        {
            time += Time.deltaTime; //increase time
            transform.localScale = Vector2.one * grow.Evaluate(time); //increase the local scale based on animation curve
        }
    }

    void movement()
    {
        if(t < 1)
        {
            t += Time.deltaTime;
        } else if(t >= 1)
        {
            t = 0f;
            time = 0f;
        }

        transform.position = Vector2.Lerp(start.position, end.position, move.Evaluate(t));
    }
}
