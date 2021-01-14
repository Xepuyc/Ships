using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathShips : MonoBehaviour
{
    public GameObject dozor;
    public GameObject destroyAsterroids1;
    
    public GameObject LoseGame;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SourceGlobal sourceGlobal = dozor.GetComponent<SourceGlobal>();
        DestroyAsteroids destroyAsteroids = destroyAsterroids1.GetComponent<DestroyAsteroids>();

       
        switch (collision.tag)
        {
            case ("Asteroids"):
                Time.timeScale = 0;               
                destroyAsteroids.RandomObject(collision);
                Instantiate(LoseGame);
                break;
            case "Coints":
                sourceGlobal.Source += 10;
                destroyAsteroids.RandomObject(collision);
                break;
            case "Bonus":
                sourceGlobal.DNK++;
                //if (sourceGlobal.speed >0.085)
                //sourceGlobal.speed *= 0.9f;
                //else sourceGlobal.speed = 0.085f;
                destroyAsteroids.RandomObject(collision); 
              
                break;
            case ("BossAmmo"):
                Time.timeScale = 0;
                Destroy(collision.gameObject);
                Instantiate(LoseGame);
                break;

        }

    }
   


}
