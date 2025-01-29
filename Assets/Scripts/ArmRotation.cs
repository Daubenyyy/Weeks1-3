using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmRotation : MonoBehaviour
{
    //declare rotation Speed
    public float rotateSpeed = 15f;

    void Start()
    {
        
    }

    void Update()
    {
        armStrum();
    }

    void armStrum()
    {
        //gets mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //object rotates on the z axis based on the mouses y position
        transform.rotation = Quaternion.Euler(0, 0, (mousePos.y) * rotateSpeed);
    }
}
