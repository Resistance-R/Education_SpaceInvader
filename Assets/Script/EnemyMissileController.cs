using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissileController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Destroy" || collision.collider.tag == "Enemy" || collision.collider.tag == "Player")
        {
            Destroy(this.gameObject);
            Debug.Log("hit!");
        }
    }
}
