using UnityEngine;

public class Ammo_true : MonoBehaviour
{

    private void OnMouseDown()
    {
        if (money.DNK >= money.PriceAmmo && !money.ammo)
        {
            money.ammo = true;
            money.DNK -= money.PriceAmmo;            
            Transparent(0.8f);

        }

    }
    private void FixedUpdate()
    {
        Transparent(0.8f);
    }
    void Start()
    {
       Color color = gameObject.GetComponent<Renderer>().material.color;
        if (money.DNK < money.PriceAmmo)
        {
            float a = 0.5f;
            Transparent(a);
        }
        else
        {
            float a = 1f;
           Transparent(a);            
        }

    }


    public void Transparent(float a)
    {
        Color color = gameObject.GetComponent<Renderer>().material.color;
        color.a = a;
        gameObject.GetComponent<Renderer>().material.color = color;
    }
}
