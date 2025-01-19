using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnSound : MonoBehaviour
{
    public bool Do = false;

    private void Update()
    {
        if (Do) 
        {
            GetComponent<AudioSource>().Play();
            Do = false;
        }
    }
}
