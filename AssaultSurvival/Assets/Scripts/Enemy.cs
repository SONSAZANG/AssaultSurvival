using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform targetDestination;
    GameObject targetGameobject;
    [SerializeField] float speed;

    Rigidbody2D rgbd2d;

    private void Awake()
    {
        rgbd2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        targetDestination = GameObject.Find("Player").transform;
    }
    private void FixedUpdate()
    {
        Vector3 direction = (targetDestination.position - transform.position).normalized;

        if (direction.x < 0)
            transform.localScale = new Vector3(-2f, 2f, 2f);
        else if (direction.x > 0)
            transform.localScale = new Vector3(2f, 2f, 2f);

        rgbd2d.velocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == targetGameobject)
        {
            Attack();
        }
    }

    private void Attack()
    {
        Debug.Log("Attack Player!!");
    }
}
