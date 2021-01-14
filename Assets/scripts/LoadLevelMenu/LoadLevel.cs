using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    

    private void OnMouseUp()
    {
        //SceneManager.UnloadSceneAsync(gameObject.name);
        SceneManager.LoadSceneAsync(gameObject.name);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
