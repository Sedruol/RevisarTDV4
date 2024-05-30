using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question8 : MonoBehaviour
{
    public int number = 222;
    void TypeNumber(int n)
    {
        if (number > 0)
        {
            Debug.Log("El número " + n + " es un número positivo");
        }
        else if (number < 0)
        {
            Debug.Log("El número " + n + " es un número negativo");
        }
        else
        {
            Debug.Log("El número " + n + " es un número nulo");
        }
    }
    void Start()
    {
        TypeNumber(number);
    }
}