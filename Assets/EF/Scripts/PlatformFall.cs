using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{
    public float timeToFall = 2f;
    private float timer = 0f;
    private Rigidbody2D rb;
    private PolygonCollider2D polygon;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        polygon = GetComponent<PolygonCollider2D>();
    }
    private void Falling()
    {
        rb.gravityScale = 1;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        //polygon.enabled = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //opcion A
            //Invoke("Falling", timeToFall);
            //opcion B
            timer = 0f;
        }
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            timer += Time.deltaTime;
            if (timer >= timeToFall)
            {
                Falling();
            }
        }
    }
}
