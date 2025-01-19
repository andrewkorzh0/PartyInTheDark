using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
public class Player : MonoBehaviour
{
    new Rigidbody2D rb;
    float speed = 2f;
    [SerializeField] GameObject camera;
    [SerializeField] GameObject noise; // ?!
    [SerializeField] GameObject lightObject;
    public bool canMove = true;

    //act vars
    public bool greenKey = false;
    public bool firstDeath = true;
    public bool p1 = false;
    public bool p2 = false;
    public bool p3 = false;
    public bool p4 = false;
    public bool lightIsOn = true;
    public bool gatesKey = false;
    //
    private void Awake()
    {
	/*
        //string savePath = @"C:\Users\" + System.Environment.GetEnvironmentVariable("USERNAME") + @"\Desktop\hello.death";
	string savePath = @"C:\Users\LapTop\Desktop\hello.death";
        if (File.Exists(savePath)) firstDeath = false;
        else
        {
            //File.Create(@"C:\Users\" + System.Environment.GetEnvironmentVariable("USERNAME") + @"\Desktop\hello.death").Dispose();
		File.Create(@"C:\Users\LapTop\Desktop\hello.death").Dispose();
            firstDeath = true;
        }
	*/
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1.0f);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    double frameCount = 0;
    void Update()
    {
        if (canMove) 
        {
            if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                rb.MovePosition(new Vector2(gameObject.transform.position.x + Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, gameObject.transform.position.y + Input.GetAxisRaw("Vertical") * speed * Time.deltaTime));
                print("move");
                frameCount += 1;
            }
            else frameCount = 0;
            if (Input.GetKeyDown(KeyCode.F) && canMove) lightObject.SetActive(!lightObject.activeInHierarchy);
        }
        if (frameCount == 40)
        {
            frameCount = 0;
            print("step sound");
            GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>().step();
        }

        camera.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -10);
        noise.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0);
        
    }

    /*
    void OnDrawGizmosSelected()
    {
        Gizmos.DrawLine(gameObject.transform.position, gameObject.transform.up * 2);
    }
    */
}
