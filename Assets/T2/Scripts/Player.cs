using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public GameObject bullet;
    public GameObject effect;
    public Transform parentBullet;
    PolygonCollider2D polygon;
    Vector3 movDirection;
    SpriteRenderer sr;
    Rigidbody2D rb;
    bool die = false;
    float movX;
    float movY;
    float hp = 100f;
    public float GetHp() { return hp; }
    public void SetHp(float _hp) { hp = _hp; }
    public void LoseHP(float dmg)
    {
        float temp = GetHp();
        temp -= dmg;
        SetHp(temp);
        Debug.Log(GetHp());
        if (GetHp() <= 0)
        {
            die = true;
            polygon.enabled = false;
            effect.SetActive(true);
            sr.enabled = false;
            Invoke("LoseMenu", 1.1f);
        }
    }
    private void LoseMenu()
    {
        GameController.Instance.LoadLoseMenu();
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        polygon = GetComponent<PolygonCollider2D>();
    }
    private void Start()
    {
        transform.position = new Vector3(0, ScalerAndMovBG.minY + 0.5f, 0);
        effect.SetActive(false);
    }
    private void Update()
    {
        if (!die)
        {
            movX = Input.GetAxis("Horizontal");
            movY = Input.GetAxis("Vertical");
        }
        else
        {
            movX = 0;
            movY = 0;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, transform.position, Quaternion.Euler(0f, 0f, 180f), parentBullet);
        }
    }
    private void FixedUpdate()
    {
        movDirection = new Vector3(movX, movY, 0);
        rb.velocity = movDirection * speed;
    }
    private void LateUpdate()
    {
        rb.position = new Vector3(Mathf.Clamp(rb.position.x, ScalerAndMovBG.minX, ScalerAndMovBG.maxX),
            Mathf.Clamp(rb.position.y, ScalerAndMovBG.minY, 0), 0);
    }
}