using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}