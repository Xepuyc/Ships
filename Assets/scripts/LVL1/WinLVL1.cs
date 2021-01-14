using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLVL1 : MonoBehaviour
{
    public int WinScore;
    public GameObject WinGame;
    void FixedUpdate()
    {
        if (GameObject.Find("Dozor").GetComponent<SourceGlobal>().DNK == WinScore && Time.timeScale!=0)
        {
            Time.timeScale = 0;
            Instantiate(WinGame);
            
        }
    }
}
