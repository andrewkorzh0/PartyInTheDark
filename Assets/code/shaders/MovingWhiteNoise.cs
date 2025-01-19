using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWhiteNoise : MonoBehaviour
{
    Material material;

    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }
    void Update()
    {
        material.SetVector("_Pos", new Vector2(
                material.GetVector("_Pos").x + Random.Range(-5, 5),
                material.GetVector("_Pos").y + Random.Range(-5, 5)));
        //print(material.GetVector("_Pos"));
    }
}
