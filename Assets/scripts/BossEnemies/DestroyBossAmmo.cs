using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBossAmmo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BossAmmo")
            Destroy(collision.gameObject);
    }
}
