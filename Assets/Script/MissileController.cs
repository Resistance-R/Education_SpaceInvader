using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour
{
    [SerializeField]
    private float missileSpeed  = 1f;

    private Rigidbody2D MissileRigid;

    private Vector3 dir;

    void Start()
    {
        Rigidbody2D MissileRigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MissileUp();
    }

    private void MissileUp()
    {
    float MissileX = GameObject.Find("Player").transform.position.x;
    this.transform.position = new Vector3(MissileX ,this.dir * this.missileSpeed * Time.deltaTime, 0f);
    }
}
