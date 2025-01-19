using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class deathscreen : MonoBehaviour
{
    Material material;
    [SerializeField] public bool death = false;
    bool work = false;

    public void doWork(){
        if (work == false)
        {
            death = true;
            work = true;
        }
    }
    private void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }
    void Update()
    {
        if (death)
        {
            GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>().loudthing();
            if (material.GetFloat("_Vector") >= 2f)
            {
                StartCoroutine(waitfor());
                death = false;
            }
            material.SetFloat("_Vector", material.GetFloat("_Vector") + .05f);
        }
    }
    IEnumerator waitfor()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().canMove = false;
        yield return new WaitForSeconds(1.0f);
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        GetComponent<SpriteRenderer>().color = Color.black;
        yield return new WaitForSeconds(1.0f);
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().firstDeath) SceneManager.LoadScene(1);
        else 
        {
            Application.Quit();
            //UnityEditor.EditorApplication.isPlaying = false;
        }
    }

    
    IEnumerator waitforfive()
    {
        yield return new WaitForSeconds(5.0f);
        //death screen
    }

}
