using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    actionParent actObject;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<actionParent>() != null) actObject = collision.gameObject.GetComponent<actionParent>();
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<actionParent>() != null) actObject = null;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && actObject != null)
        {
            actObject.action();
        }
    }
}

public abstract class actionParent : MonoBehaviour
{
    public abstract void action();
}