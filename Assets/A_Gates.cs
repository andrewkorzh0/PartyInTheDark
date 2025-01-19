using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_Gates : actionParent
{
    public override void action()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().gatesKey == true) Destroy(gameObject);
    }
}
