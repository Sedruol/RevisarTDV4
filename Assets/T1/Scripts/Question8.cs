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
            Debug.Log("El n�mero " + n + " es un n�mero positivo");
        }
        else if (number < 0)
        {
            Debug.Log("El n�mero " + n + " es un n�mero negativo");
        }
        else
        {
            Debug.Log("El n�mero " + n + " es un n�mero nulo");
        }
    }
    void Start()
    {
        TypeNumber(number);
    }
}