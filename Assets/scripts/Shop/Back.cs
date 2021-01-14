
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    private void OnMouseUp()
    {
        SceneManager.LoadScene(1);
    }

}