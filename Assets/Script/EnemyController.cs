using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Missile")
        {
            Destroy(this.gameObject);
        }
    }
}
