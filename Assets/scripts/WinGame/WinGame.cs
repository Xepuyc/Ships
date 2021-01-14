using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    private void OnMouseDown()
    {

        money.Coints+= GameObject.Find("Dozor").GetComponent<SourceGlobal>().Source;
        money.AsteroidsCoints+=GameObject.Find("Dozor").GetComponent<SourceGlobal>().AsteroidsCoints;
        money.DNK+= GameObject.Find("Dozor").GetComponent<SourceGlobal>().DNK;
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    
    }
}
