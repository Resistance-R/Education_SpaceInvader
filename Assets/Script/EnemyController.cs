using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float movement = 1f; 
    public float distance = 0.5f; 

    private float startPosition; 
    private float direction = 0.5f; 


    void Start()
    {
        startPosition = transform.position.x;
        InvokeRepeating("EnMovement", 1f, 7f);
    }

    void Update()
    {

    }

    private void EnMovement()
    {
        transform.Translate(new Vector3(movement * direction, -distance * 0.5f, 0));

        if (transform.position.x > startPosition + distance / 2 || transform.position.x < startPosition - distance / 2)
        {
            direction *= -1f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Missile")
        {
            Destroy(this.gameObject);
        }
    }

   
}
