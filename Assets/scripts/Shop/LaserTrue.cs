using UnityEngine;

public class LaserTrue : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (money.DNK >= money.PriceLaser && !money.TripleLaser)
        {
            money.TripleLaser = true;
            money.DNK -= money.PriceLaser;
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
        if (money.DNK < money.PriceLaser)
        {
            float a = 0.5f;
            Transparent(a);
        }
        else
        {
            float a = 2f;
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
