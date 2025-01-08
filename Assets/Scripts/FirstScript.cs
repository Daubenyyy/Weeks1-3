using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += (speed * Time.deltaTime);

        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        if (squareInScreenSpace.x < 0 || squareInScreenSpace.x > Screen.width)
        {
            speed = speed * -1;
        }
        transform.position = pos;
    }
}
