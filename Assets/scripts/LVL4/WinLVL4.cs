using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLVL4 : MonoBehaviour
{
    public float WinScore;
    public GameObject WinGame;
    private float win;
    void FixedUpdate()
    {
        if (WinScore <= win && Time.timeScale != 0)
        {
            Time.timeScale = 0;
            Instantiate(WinGame);

        }
        else win += Time.deltaTime;

    }
   
}
