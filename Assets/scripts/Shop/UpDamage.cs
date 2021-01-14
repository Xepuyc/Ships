using UnityEngine;

public class UpDamage : MonoBehaviour
{
    public TextMesh Price;
    private void FixedUpdate()
    {


        if ( money.PriceDamage <= money.DNK)
        {
            Color color = gameObject.GetComponent<Renderer>().material.color;
            color.a = 2f;
            gameObject.GetComponent<Renderer>().material.color = color;
        }
    }
    private void OnMouseDown()
    {
        if(money.DNK>=money.PriceDamage)
        {
            
            money.DNK -= money.PriceDamage;
            PlayerShipsAtribute.Damage++;
            Price.text = $"{money.PriceDamage} DNK";


        }
    }
    private void Start()
    {
        Price.text = $"{money.PriceDamage} DNK";
    }

}
