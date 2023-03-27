using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour
{

    private Rigidbody2D MissileRigid;

    void Start()
    {
        Rigidbody2D MissileRigid = GetComponent<Rigidbody2D>();
    }

    void Awake()
    {
        MissileUp();
    }

    void Update()
    {

    }

    private void MissileUp()
    {
    float MissileX = GameObject.Find("Player").transform.position.x;
    this.transform.position = new Vector3(MissileX, -4f ,0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Destroy" || collision.collider.tag =="Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
