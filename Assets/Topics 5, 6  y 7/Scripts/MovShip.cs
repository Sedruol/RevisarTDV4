using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovShip : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    float movX;
    float movY;
    Vector3 mov;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");

        mov = new Vector3(movX, movY, 0);
        rb.velocity = mov * speed;
    }
    private void LateUpdate()
    {
        rb.position = new Vector3(Mathf.Clamp(rb.position.x, BackgroundScaler.minX, BackgroundScaler.maxX), rb.position.y, 0);
    }
}