using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRight : MonoBehaviour
{
   
    private void OnMouseDown()
    {

        Next();
        
    }
  void Next()
    {
        if (Inventory.Number == GameObject.Find("Inventory").GetComponent<Inventory>().Bullet.Length - 1)
        {
            (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].transform.position, GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[0].transform.position) = (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[0].transform.position, GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].transform.position);
            (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].transform.localScale, GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[0].transform.localScale) = (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[0].transform.localScale, GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].transform.localScale);

            Inventory.Number = 0;
        }
        else
        {
            (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].transform.position, GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number + 1].transform.position) = (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number + 1].transform.position, GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].transform.position);
            (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].transform.localScale, GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number + 1].transform.localScale) = (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number + 1].transform.localScale, GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].transform.localScale);

            Inventory.Number++;
        }
        GameObject.Find("ArrowLeft").GetComponent<ArrowLeft>().CheckPurchase();
    }

}
