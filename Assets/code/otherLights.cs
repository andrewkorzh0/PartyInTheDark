using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherLights : MonoBehaviour
{
    int seeTime = 0;
    [SerializeField] float SeeTime = 60f;

    private void Update()
    {
        RaycastHit2D[] hits;
        if (SeeTime == 10) hits = Physics2D.RaycastAll(gameObject.transform.position, gameObject.transform.up, 1.2f);
        else hits = Physics2D.RaycastAll(gameObject.transform.position, gameObject.transform.up, 2f);
        bool enemySeen = false;
        foreach (RaycastHit2D i in hits)
        {
            if (i.collider.gameObject.tag == "enemy") enemySeen = true;
        }
        if (enemySeen == true) seeTime += 1;
        if (seeTime >= SeeTime) GameObject.FindGameObjectWithTag("death").GetComponent<deathscreen>().death = true;
        Vector2 lightDirection = (gameObject.transform.position - gameObject.transform.up * -2.1f);
        Debug.DrawLine(gameObject.transform.position, lightDirection);
    }
}
