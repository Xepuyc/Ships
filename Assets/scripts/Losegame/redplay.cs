using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redplay : MonoBehaviour
{
    public GameObject _Form;
    private void OnMouseDown()
    {
        Time.timeScale = 1;
        Destroy(_Form);
    }
}
