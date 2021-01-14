using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SourceGlobal : MonoBehaviour
{
    public Text _source;
    public  int Source=0;
    public  bool ammo = false;
    public float speed = 1f;
    public  bool life = false;
    public int AsteroidsCoints=0;
    public Text _AsteroidsCoints;
    public int DNK=0;
    public Text _DNK;

    private void Update()
    {
        _source.text = $"Счёт {Source}";
        _AsteroidsCoints.text = $"астероиды {AsteroidsCoints}";
        _DNK.text = $"Собрано ДНК {DNK}";
    }

}
