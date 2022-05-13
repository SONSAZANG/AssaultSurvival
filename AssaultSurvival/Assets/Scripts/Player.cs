using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{

    Rigidbody2D rgbd2d;
    [SerializeField] float speed = 0.0f;
    private BoxCollider2D boxCollider;

    public Animator animator;
    
    private Vector3 movementVector;
    [SerializeField] private Joystick joystick;
    [SerializeField] GameObject KnifePrefab;
    // public float speed = 5;
    private void Awake()
    {
        rgbd2d = GetComponent<Rigidbody2D>();
        movementVector = new Vector3();
    }

    private void FixedUpdate()
    {
        Move();
        WorldColliderCheck();
    }

    private void LateUpdate()
    {
        
    }
    public void Move()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");

        

        if (movementVector.x > 0)
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        else if (movementVector.x < 0)
            transform.localScale = new Vector3(-0.3f, 0.3f, 0.3f);

        movementVector *= speed;
        animator.SetFloat("Speed", Mathf.Abs((movementVector.x + movementVector.y) * speed));
        rgbd2d.velocity = movementVector;
    }
    public void WorldColliderCheck()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);

        if (pos.x < 0.05f) pos.x = 0.05f;
        if (pos.x > 0.95f) pos.x = 0.95f;
        if (pos.y < 0.1f) pos.y = 0.1f;
        if (pos.y > 0.9f) pos.y = 0.9f;

        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }

    public void AttackBtn()
    {
        
    }
}
