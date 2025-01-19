using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_CollectPuzzle : actionParent
{
    [SerializeField] int number;
    bool inaction = false;
    bool audio = false;
    public override void action()
    {
        if (!inaction)
        {
            inaction = true;
            switch (number)
            {
                case 1:
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().p1 = true;
                    break;
                case 2:
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().p2 = true;
                    break;
                case 3:
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().p3 = true;
                    break;
                case 4:
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().p4 = true;
                    break;
            }
            if (audio == false)
            {
                StartCoroutine(wait());
            }
            else return;

        }
    }
    IEnumerator wait()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(3.0f);
        Destroy(gameObject);

    }
}
