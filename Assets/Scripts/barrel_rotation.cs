using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrel_rotation : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        Rotation();
    }

    private void Rotation()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.Euler (0, 0, (mousePos.y) * rotateSpeed);
    }
}
