using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public ParticleSystem effect;
    public float points;
    public float damage;
    public float speed;
    Rigidbody2D rb;
    private void Awake()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        rb.velocity = new Vector2(rb.velocity.x, -speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(effect.gameObject, transform.position, Quaternion.identity);
            collision.gameObject.GetComponent<Player>().LoseHP(damage);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Bullet"))
        {
            Instantiate(effect.gameObject, transform.position, Quaternion.identity);
            GameController.Instance.AddPoints(points);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}