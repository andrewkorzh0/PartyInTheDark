using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNoiseEffect : MonoBehaviour
{
    Material material;
    [SerializeField] Vector2 Size;
    bool noiseFree = false;
    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    void FixedUpdate()
    {
        if (!noiseFree)
        {
            material.SetFloat("_Size", Random.Range(Size.x, Size.y));//5,15
            material.SetFloat("_X", Random.Range(0, 10));
        }
        else
        {
            material.SetFloat("_Size", 0);//5,15
            material.SetFloat("_X", 0);
        }

    }
}
