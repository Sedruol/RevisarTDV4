using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScaler : MonoBehaviour
{
    private float height;
    private float width;
    public float scrollSpeed;
    private MeshRenderer mesh;
    private Vector2 offset;
    public static float minX;
    public static float maxX;
    private void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
    }
    void Start()
    {
        height = Camera.main.orthographicSize * 2.0f; //alto de la camara. 
        width = height * Screen.width / Screen.height;
        minX = (-width / 2) + 0.5f;
        maxX = (width / 2) - 0.5f;
        Debug.Log("height: " + height + ", width: " + width);
        transform.position = new Vector3(0, 0, 1);
        transform.localScale = new Vector3(width, height, 1);
    }
    private void Update()
    {
        offset = new Vector2(0, Time.time * scrollSpeed);
        mesh.material.mainTextureOffset = offset;
    }
}