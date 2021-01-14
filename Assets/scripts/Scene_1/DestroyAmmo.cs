using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAmmo : MonoBehaviour
    
{
    public int damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.tag != "Player"&& collision.tag != "ammo")
       
        {
            switch (collision.tag)
            {
                case ("enemy"):
                    collision.gameObject.GetComponent<HealsPoints>().GetDamage(damage*PlayerShipsAtribute.Damage);
                    break;
                case ("Asteroids"):
                    GameObject.Find("Dozor").GetComponent<SourceGlobal>().AsteroidsCoints++;
                    GameObject.Find("DestroyAsteroids").GetComponent<DestroyAsteroids>().RandomObject(collision);
                    break;                    
            }
            Destroy(gameObject);
         
        }

    }
    
    
}
