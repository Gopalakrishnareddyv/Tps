using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody rb;
    EnemyMovement enemy;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        enemy = GameObject.Find("Enemy").GetComponent<EnemyMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = enemy.transform.forward * speed;
    }
}
