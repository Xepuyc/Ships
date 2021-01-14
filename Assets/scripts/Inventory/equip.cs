using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class equip : MonoBehaviour
{
    private void OnMouseUp()
    {
        string ObjectName = GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].name;
        money.Bullet = Resources.Load<GameObject>(ObjectName);
     
    }
}
