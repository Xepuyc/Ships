using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WintestLvl : MonoBehaviour
{
    public GameObject WinGame;
    // Start is called before the first frame update
    private void OnMouseUp()
    {
        Instantiate(WinGame);
    }
}
