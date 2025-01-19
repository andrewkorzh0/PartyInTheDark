using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalclose : MonoBehaviour
{
    void Awake()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
