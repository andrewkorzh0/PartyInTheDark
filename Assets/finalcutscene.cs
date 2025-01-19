using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class finalcutscene : actionParent
{
    [SerializeField] GameObject director; 
    public override void action()
    {
        director.SetActive(true);
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().lightIsOn = false;
        GameObject.FindGameObjectWithTag("Player").transform.rotation = new Quaternion(0, 0, 0, 0);
        Destroy(gameObject);
    }
}
