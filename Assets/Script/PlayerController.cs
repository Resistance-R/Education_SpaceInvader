using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1f;

    [SerializeField]
    private GameObject MissilePrefab;

    private Rigidbody2D myRigid;

    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Shoot();
    }

    private void Move()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        myRigid.velocity = new Vector2(moveInput * moveSpeed, -4f);
    }

    private void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Missile = Instantiate(MissilePrefab, transform.position, Quaternion.identity);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag == "EnemyMisslie")
        {
            Destroy(this.gameObject);
            Time.timeScale = 0f;
            Debug.Log("Game is Over!");
        }
    }
}
