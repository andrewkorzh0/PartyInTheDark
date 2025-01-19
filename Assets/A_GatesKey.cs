using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_GatesKey : actionParent
{
    public override void action()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().gatesKey = true;
        Destroy(gameObject);
    }
}
