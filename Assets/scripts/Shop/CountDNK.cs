using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDNK : MonoBehaviour
{
    public Text text;
    private void FixedUpdate()
    {
        text.text = $"{money.DNK} DNK";
    }
}
