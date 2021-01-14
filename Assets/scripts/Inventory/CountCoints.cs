using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountCoints : MonoBehaviour
{
    public Text Count;
    private void FixedUpdate()
    {
        Count.text = $"{money.Coints} Coins";
    }

}
