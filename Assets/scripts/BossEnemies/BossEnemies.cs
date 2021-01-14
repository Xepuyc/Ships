using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemies : MonoBehaviour
{
    public GameObject Player;
    float timer = 0;
    public GameObject _BossAmmo;  
    bool move = true;
    float posY = 0;
    byte secondAttack, thirdAttack = 0;


    
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("ammo"))
    //    {
    //        GameObject bullet = collision.gameObject;
     
            
    //    }
    //    if (life <= 0)
    //    {
    //        money.DNK += 1000;
    //        Destroy(gameObject);
    //        Instantiate(_WinGame);
    //    }
    //}
    private void FixedUpdate()
    {
        Move();
        Guns();
    }

    private void Move()
    {
        if (move)
        {
            posY += 0.09f;
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.01f, gameObject.transform.position.y + Mathf.Sin(posY) * 0.1f);
            if (gameObject.transform.position.x > 2)
                move = false;
        }
        else
        {
            posY -= 0.09f;
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.01f, gameObject.transform.position.y - Mathf.Sin(posY) * 0.1f);
            if (gameObject.transform.position.x < -2)
                move = true;
        }
       
    }
    private void Guns()
    {
        if (timer <= 0)
        {
            if (secondAttack != 3 && thirdAttack != 5)
            {
                Attack();
                secondAttack++;
                thirdAttack++;
            }
            else if (secondAttack == 3)
            {
                SecondAttack();

            }
            else if (thirdAttack == 5)
            {
                ThirdAttack();

            }
            timer = 0.5f;

        }
        else timer -= Time.deltaTime;


    }
    private void Attack()
    {        
            ShotPosition(gameObject.transform.position.x,gameObject.transform.position.y-2, new Vector2(0,-1));          
       
    }
    private void SecondAttack()
    {
        for (int i = -1; i < 2; i++ )
        ShotPosition(gameObject.transform.position.x+i*0.2f, gameObject.transform.position.y - 2, new Vector2(i*0.3f, -1));
        secondAttack = 0;
    }

    private void ThirdAttack()
    {
        ShotPosition(gameObject.transform.position.x, gameObject.transform.position.y - 2, new Vector2 (Player.transform.position.x/3,Player.transform.position.y/3));
        thirdAttack = 0;
     
    }

    private void ShotPosition(float ShotPosX, float ShotPosY, Vector2 ShotDirection)
    {
        _BossAmmo.transform.position = new Vector3(ShotPosX, ShotPosY);
        Instantiate(_BossAmmo).GetComponent<Rigidbody2D>().AddForce(ShotDirection * 0.02f);
    }
}
