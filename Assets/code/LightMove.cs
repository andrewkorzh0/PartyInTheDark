using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMove : MonoBehaviour
{
    Vector2 mousePosition;
    Vector2 direction;
    void Update()
    {
        if (GetComponentInParent<Player>().canMove) 
        {
            print(new Vector2(1, 1).magnitude);
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if((new Vector3(mousePosition.x, mousePosition.y, 0) - transform.position).magnitude >= .5)
            direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
            transform.up = direction;
        }

    }
}
