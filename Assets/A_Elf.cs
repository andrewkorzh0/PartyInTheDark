using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_Elf : actionParent
{
    [SerializeField] GameObject[] parts;
    [SerializeField] GameObject part1;
    [SerializeField] GameObject part2;
    [SerializeField] GameObject part3;
    [SerializeField] GameObject part4;
    [SerializeField] GameObject words;
    [SerializeField] GameObject collider;
    public override void action()
    {
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        if (player.p1 == true)
        {
            part1.SetActive(true);
            print("FIRST PART");
        }
        if (player.p2 == true) part2.SetActive(true);
        if (player.p3 == true) part3.SetActive(true);
        if (player.p4 == true) part4.SetActive(true);
        
        if (player.p1 == true &&
            player.p2 == true &&
            player.p3 == true &&
            player.p4 == true)
        {
            StartCoroutine(wordss());
            GetComponent<AudioSource>().Play();
            collider.SetActive(false);
            
        }
    }
    
    IEnumerator wordss()
    {
        words.SetActive(true);
        yield return new WaitForSeconds(2f);
        words.SetActive(false);
    }
}
