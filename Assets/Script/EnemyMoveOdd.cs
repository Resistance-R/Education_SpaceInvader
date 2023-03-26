using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveOdd : MonoBehaviour
{
    [SerializeField]
    private float EnposX = 0;

    [SerializeField]
    private float EnposY = 0;

    [SerializeField]
    private bool isImpact = false;

    [SerializeField]
    private bool isKill = false;

    [SerializeField]
    private float countUp = 0;

    void Start()
    {
        
    }

    void Update()
    {
        EnMoving();
    }


    private void EnMoving()
    {
     if(isImpact == false && isKill == false)
     {
        EnposX += 1;
        EnposY -= 1f;
        this.transform.position = new Vector3(EnposX, EnposY, 0f);
     }

        if (isImpact == true && isKill == false)
        {
            EnposX -= 1;
            EnposY -= 1f;
            this.transform.position = new Vector3(EnposX, EnposY, 0f);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Wall" || collision.collider.tag == "Enemy")
        {
            isImpact = true;
        }
    }

    private void OnCollisionEnter2D_2(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            isKill = true;
        }
    }
}
