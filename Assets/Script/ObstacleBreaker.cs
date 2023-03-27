using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBreaker : MonoBehaviour
{
    [SerializeField]
    private float fullDefend = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Missile" || collision.collider.tag == "EnemyMisslie")
        {
            fullDefend -= 1f;

            if(fullDefend == 0f)
            {
            Destroy(this.gameObject);
            }
        }
    }
}
