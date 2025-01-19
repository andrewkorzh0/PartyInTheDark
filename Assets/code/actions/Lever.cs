using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : actionParent
{
    [SerializeField] GameObject gates;
    bool yes = true;
    public override void action()
    {
        if (yes) 
        {
            gates.SetActive(false);
            GetComponent<AudioSource>().Play();
            yes = false;
        }
        
    }

}
