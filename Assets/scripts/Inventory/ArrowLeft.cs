using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowLeft : MonoBehaviour
{
    [SerializeField] private GameObject Buy;
    [SerializeField] private GameObject Equip;
    private GameObject BuyEquip;
    int Length;
    private void OnMouseDown()
    {

        Next();
      
    }
    private void Start()
    {
        
        Length =  GameObject.Find("Inventory").GetComponent<Inventory>().Bullet.Length - 1;
        BuyEquip= Instantiate(Buy);
        CheckPurchase();
    }

    private void Next()
    {
          if (Inventory.Number == 0)
          {
            (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].transform.position, GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Length].transform.position) = (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Length].transform.position, GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].transform.position);
            (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].transform.localScale, GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Length].transform.localScale) = (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Length].transform.localScale, GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].transform.localScale);

            Inventory.Number = Length;
          }
          else
          {
            (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].transform.position, GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number - 1].transform.position) = (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number - 1].transform.position, GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].transform.position);
            (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].transform.localScale, GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number - 1].transform.localScale) = (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number - 1].transform.localScale, GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].transform.localScale);

            Inventory.Number--;

          }
        CheckPurchase();
    }
    public void CheckPurchase()
    {
        if (GameObject.Find("Inventory").GetComponent<Inventory>().Bullet[Inventory.Number].GetComponent<Price>().buy)
        {
            Destroy(BuyEquip);
            BuyEquip = Instantiate(Equip);
            
        }
        else
        {
            Destroy(BuyEquip);
            BuyEquip= Instantiate(Buy);
            
        }
    }
    
}
