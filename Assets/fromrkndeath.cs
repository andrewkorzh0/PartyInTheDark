using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fromrkndeath : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") GameObject.FindGameObjectWithTag("death").GetComponent<deathscreen>().death = true;
    }
}
