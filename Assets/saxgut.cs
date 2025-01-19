using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saxgut : MonoBehaviour
{
    bool yes = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!yes && collision.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            yes = true;
        }

    }
}
