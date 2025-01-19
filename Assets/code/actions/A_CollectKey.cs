using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_CollectKey : actionParent
{
    public override void action()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().greenKey = true;
        Destroy(gameObject);
    }
}
