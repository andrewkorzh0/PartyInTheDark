using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_GreenDoor : actionParent
{
    public override void action()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().greenKey == true) Destroy(gameObject);
    }
}
