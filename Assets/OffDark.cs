using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffDark : MonoBehaviour
{
    [SerializeField] bool Light;
    [SerializeField] GameObject LightObj;
    [SerializeField] GameObject noise;
    [SerializeField] GameObject globalLight;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().lightIsOn != Light)
                GetComponent<AudioSource>().Play();
            if (Light) LightObj.SetActive(true);
            else LightObj.SetActive(false);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().lightIsOn = Light;
            noise.SetActive(false);
            globalLight.SetActive(true);
            GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>().work = false;
        }
    }
}
