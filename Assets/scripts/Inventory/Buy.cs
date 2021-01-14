using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    private void OnMouseUp()
    {
        if (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].GetComponent<Price>().price <= money.Coints)
        {
            GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].GetComponent<Price>().buy = true;
            GameObject.Find("ArrowLeft").GetComponent<ArrowLeft>().CheckPurchase();
            money.Coints -= GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].GetComponent<Price>().price;
        }
    }
}
