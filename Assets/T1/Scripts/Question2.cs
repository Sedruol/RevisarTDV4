using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question2 : MonoBehaviour
{
    public int number = 4;
    void IsPair(int n)
    {
        if (n % 2 == 0)
        {
            Debug.Log("El n�mero " + n + " es par.");
        }
        else
        {
            Debug.Log("El n�mero " + n + " es impar.");
        }
    }
    void Start()
    {
        IsPair(number);
    }
}