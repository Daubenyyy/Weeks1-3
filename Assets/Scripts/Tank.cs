using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] private float Speed = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        Vector2 pos = transform.position;
        pos.x += (Input.GetAxis("Horizontal") * Speed) * Time.deltaTime;
        transform.position = pos;
    }
}
