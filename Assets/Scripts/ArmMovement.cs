using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMovement : MonoBehaviour
{
    //speed varible
    public float Speed = 0.5f;
    public float mouseOffset = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        followMouse();
    }

    void followMouse()
    {
        //follow the mouse on the X axis
        Vector2 pos = transform.position;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //getting mouse position
        pos.x = (mousePos.x * Speed) + mouseOffset; //arm moves along the x axis only
        transform.position = pos;
        
    }
}
