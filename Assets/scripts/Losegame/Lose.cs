using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    
    private void OnMouseDown()
    {
        
        GameObject.Find("Dozor").GetComponent<SourceGlobal>().Source = 80;
        GameObject.Find("Dozor").GetComponent<SourceGlobal>().ammo = false;
        GameObject.Find("Dozor").GetComponent<SourceGlobal>().speed = 1f;
        GameObject.Find("Dozor").GetComponent<SourceGlobal>().life = false;
        GameObject.Find("Dozor").GetComponent<SourceGlobal>().AsteroidsCoints=0;
        GameObject.Find("Dozor").GetComponent<SourceGlobal>().DNK =0;
    

    SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
