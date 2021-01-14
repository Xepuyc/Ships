using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpAmmo : MonoBehaviour
{
    public TextMesh Price; 
  
    private void FixedUpdate()
    {
        
        if (money.ammo&& money.PriceAmmo<money.DNK)
        {            
            Color color = gameObject.GetComponent<Renderer>().material.color;
            color.a = 2f;
            gameObject.GetComponent<Renderer>().material.color = color;
        }
        

    }
    private void OnMouseDown()
    {
        
        if (money.ammo)
            if (money.PriceAmmo <= money.DNK)
            {
                money.DNK -= money.PriceAmmo;
                money.speedAmmo *= 0.9f;
                money.PriceAmmo *= 2;
                Price.text = $"{money.PriceAmmo} DNK";

            }
    }
    private void Start()
    {
        Price.text = $"{money.PriceAmmo} DNK";
    }
}
