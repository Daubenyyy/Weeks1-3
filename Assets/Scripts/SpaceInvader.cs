using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceInvader : MonoBehaviour
{
    [SerializeField] private float Speed = 5f;
  
    void Start()
    {
        
    }

    void Update()
    {
        March();
    }

    private void March()
    {
        Vector2 pos = transform.position;
        pos.x += (Speed * Time.deltaTime);

        Vector2 SpaceInvaderInScreenSpace = Camera.main.WorldToScreenPoint(pos);
        if(SpaceInvaderInScreenSpace.x < 0 || SpaceInvaderInScreenSpace.x > Screen.width)
        {
            Speed = Speed * -1;
            pos.y = pos.y - 1;
        }

        transform.position = pos;
    }
}
