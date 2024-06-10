using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limits : MonoBehaviour
{
    BoxCollider2D boxCollider2D;
    public bool isTop;
    private void Awake()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
    private void Start()
    {
        boxCollider2D.size = new Vector2(ScalerAndMovBG.width, 1f);
        if (isTop)
        {
            transform.position = new Vector3(0f, ScalerAndMovBG.height * 0.75f);
        }
        else
        {
            transform.position = new Vector3(0f, -ScalerAndMovBG.height * 0.75f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}