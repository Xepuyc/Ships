using UnityEngine;

public class UpLaser : MonoBehaviour
{
    public TextMesh Price;

    private void FixedUpdate()
    {
        if (money.TripleLaser && money.PriceLaser < money.DNK)
        {
            Color color = gameObject.GetComponent<Renderer>().material.color;
            color.a = 2f;
            gameObject.GetComponent<Renderer>().material.color = color;
        }
    }
    private void OnMouseDown()
    {
        if (money.TripleLaser)
            if (money.PriceLaser <= money.DNK)
            {
                money.DNK -= money.PriceLaser;
                money.SpeedLaser *= 0.9f;
                money.PriceLaser *= 2;
                Price.text = $"{money.PriceLaser} DNK";
            }
    }
    private void Start()
    {
        Price.text = $"{money.PriceLaser} DNK";
    } 
}
