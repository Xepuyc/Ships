using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealsPoints : MonoBehaviour
{
    public int Heals;   
    public GameObject _WinGame;

     public void GetDamage(int damageBullet)
    {
        Heals -= damageBullet;
        if (Heals <= 0)
        {
            money.DNK += 1000;
            Destroy(gameObject);
            Instantiate(_WinGame);
        }
    }


}
