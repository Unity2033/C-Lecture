using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] float speed;
    [SerializeField] Vector2 direction;

    private FlashMaterial flashMaterial;

    private void Start()
    {
        direction = Vector2.down;
        flashMaterial = GetComponent<FlashMaterial>();
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void OnHit(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Missile"))
        {
            if (gameObject.activeSelf)
            {
                StartCoroutine(flashMaterial.HitEffect(0.125f));
            }
        }
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
