using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDeathSceneSet : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(wait5());
    }
    IEnumerator wait5()
    {
        yield return new WaitForSeconds(5f);
        StartCoroutine(wait45());
    }
    IEnumerator wait45() 
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(40f);
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
