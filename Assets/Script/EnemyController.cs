using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    [SerializeField]
    private GameObject EnemyMissilePrefab;

    public float movement = 1f; 
    public float distance = 0.5f; 

    private float startPosition; 
    private float direction = 0.5f; 

    void Start()
    {
        startPosition = transform.position.x;
        InvokeRepeating("EnMovement", 1f, 7f);
        InvokeRepeating("Shoot", TimeSelecter(), TimeSelecter());
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

    private void Shoot()
    {
        Vector3 missilePosition = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
        GameObject enemyMissile = Instantiate(EnemyMissilePrefab, missilePosition, Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Missile")
        {
            Destroy(this.gameObject);
        }
    }

    private float TimeSelecter()
    {
        float RandTime = Random.Range(1f, 5f);
        return(RandTime);
    }
   
}
