using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalerAndMovBG : MonoBehaviour
{
    public static float height;
    public static float width;
    MeshRenderer mesh;
    Vector2 offset;
    public float scrollSpeed;
    public static float minX;
    public static float maxX;
    public static float minY;
    public static float maxY;
    private void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
        //calculando dimensiones de la camara
        height = Camera.main.orthographicSize * 2;//alto de la cámara
        width = height * Screen.width / Screen.height;//ancho 
        //calculando limites de posicion
        maxY = (height / 2) - 0.5f;
        minY = (-height / 2) + 0.5f;
        minX = (-width / 2) + 0.5f;
        maxX = (width / 2) - 0.5f;
    }
    private void Start()
    {
        Debug.Log("alto: " + height + ", ancho: " + width);
        transform.position = new Vector3(0, 0, 1);
        transform.localScale = new Vector3(width, height, 1);
    }
    private void Update()
    {
        offset = new Vector2(0, Time.time * scrollSpeed);
        mesh.material.mainTextureOffset = offset;
    }
}