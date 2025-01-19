using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffLight : MonoBehaviour
{
    [SerializeField] bool Light;
    [SerializeField] GameObject LightObj;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().lightIsOn != Light)
                GetComponent<AudioSource>().Play();
            if (Light) LightObj.SetActive(true);
            else LightObj.SetActive(false);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().lightIsOn = Light;
        }
    }
}
