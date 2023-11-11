using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;

    [SerializeField] Vector2 direction;
    [SerializeField] float speed = 5.0f;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidBody2D.velocity = new Vector2(direction.x, 0) * speed * Time.fixedDeltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
