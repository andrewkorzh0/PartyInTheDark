using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource[] stepSounds;
    int step_state = 0;
    public bool work = true;
    [SerializeField] AudioSource wood;
    [SerializeField] AudioSource metal;
    [SerializeField] AudioSource loudstf;
    [SerializeField] GameObject[] enemies;
    public void step()
    {
        stepSounds[step_state].Play();
        step_state = step_state == 0 ? 1 : 0;
    }
    private void Update()
    {
        if (work){
            Vector3 playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
            float[] distance = new float[enemies.Length];
            for (int i = 0; i < distance.Length; i++)
            {
                if (enemies[i].activeInHierarchy == true) distance[i] = (enemies[i].transform.position - playerPosition).magnitude;
                else distance[i] = 666;//?!
            }
            Array.Sort<float>(distance);
            //sound part
            /*
             wood:  
             */
            //metal
            if (distance[0] <= 10) wood.volume = (float)(distance[0] / (distance[0] * (distance[0] * (distance[0] * 0.1))));
            else if (distance[0] <= 1) wood.volume = 1; //vol = 1
            else wood.volume = 0.1f;

            if (distance[0] <= 5)
            {
                metal.volume = (1 / distance[0]) * 2;
            }
            else metal.volume = 0f;
        }
    }

    public void loudthing()
    {
        loudstf.Play();
    }
}
