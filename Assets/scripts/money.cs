using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour
{

    public static int Coints = 300;
    public static bool ammo = false;
    public static float speedAmmo = 1f;    
    public static int AsteroidsCoints = 0;
    public static int DNK = 10000000;
    public static int PriceAmmo = 10;
    public static int PriceLaser = 100;
    public static bool TripleLaser = false;
    public static float SpeedLaser = 1f;
    public static GameObject Bullet =Resources.Load<GameObject>("ammo_8");
    public static bool[] BoolInventory;
    public static int PriceDamage = 1000;

    

}
