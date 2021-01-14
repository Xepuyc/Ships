using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public class DestroyAsteroids : MonoBehaviour
    
{
    public GameObject[] asteroids;
     static GameObject [] newasteroids;
     static GameObject  newa;
    static List <GameObject>  new_b = new List <GameObject>();
    private SourceGlobal sourceGlobal;
    public GameObject dozor;
    private float speedPlayer=0;
    
      
    

    private void OnTriggerEnter2D(Collider2D collision)
    
    {
        sourceGlobal = dozor.GetComponent<SourceGlobal>();


        switch (collision.tag)
        {
            case "Asteroids":
               // sourceGlobal.Source++;
                break;
            case "Coints":
                sourceGlobal.Source -= 10;               
                break;
            case "BossAmmo":
                Destroy(collision.gameObject);
                break;
                



        }
        if (collision.tag!="BossAmmo")
        RandomObject(collision);



    }


    public  void  RandomObject(Collider2D collision)
        {
        
        sourceGlobal = dozor.GetComponent<SourceGlobal>();
        Destroy(collision.gameObject);
        new_b.RemoveAt(new_b.Count-1);      

        if (new_b.Count == 0)
        {
            RandomEllements();
        }
            if (speedPlayer >= 10 && new_b.Count == 1)
            {
            RandomEllements();

            }

        if (speedPlayer >= 30 && new_b.Count == 2)
        {
            RandomEllements();
        }
        if (speedPlayer >= 45 && new_b.Count == 3)
            RandomEllements();



    }
    private void RandomEllements ()
    {
        
        byte z = (byte)Random.Range(0, newasteroids.Length);
        newa = Instantiate(newasteroids[z]);//.GetComponent<Rigidbody2D>().gravityScale = Random.Range(1f,3f);
        newa.transform.position = new Vector3(Random.Range(-2.5f, 2.5f), 5);
        newa.GetComponent<Rigidbody2D>().gravityScale = Random.Range(1f,3f);
        new_b.Add(newa);
    }


    // Start is called before the first frame update
    void Start()
    {
        new_b.Clear();
        newasteroids = asteroids;
      RandomEllements();
    }

    // Update is called once per frame
    void Update()
    {
        speedPlayer += Time.deltaTime;
        if (GameObject.Find("Top").GetComponent<BackgroundHelper>().speed<0.01f)
        GameObject.Find("Top").GetComponent<BackgroundHelper>().speed += Time.deltaTime*0.001f;

    }
}
