using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layerChanger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponentInParent<SpriteRenderer>().sortingOrder = 2;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponentInParent<SpriteRenderer>().sortingOrder = 0;
    }
}
