﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rkntrigger : MonoBehaviour
{
    [SerializeField] GameObject go;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") go.SetActive(true);
    }
}
