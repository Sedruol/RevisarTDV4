using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleMovBG : MonoBehaviour
{
    public static float height;
    public static float width;
    public float scrollSpeed;
    MeshRenderer mesh;
    Vector2 offset;
    private void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
        //calculando dimensiones de la camara
        height = Camera.main.orthographicSize * 2;//alto de la cámara
        width = height * Screen.width / Screen.height;//ancho 
    }
    private void Start()
    {
        transform.position = new Vector3(0, 0, 1);
        transform.localScale = new Vector3(width, height, 1);
        //transform.SetParent(Camera.main.transform);
    }
    private void Update()
    {
        offset = new Vector2(Time.time * scrollSpeed, 0);
        mesh.material.mainTextureOffset = offset;
    }
}