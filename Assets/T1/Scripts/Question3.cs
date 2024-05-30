using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question3 : MonoBehaviour
{
    public int number = 6;
    int CalculateFactorialNumber(int _number)
    {
        int result = 1;
        for (int i = 1; i <= _number; i++)
        {
            result *= i;
        }
        return result;
    }
    void Start()
    {
        Debug.Log("El factorial de " + number + " es: " + CalculateFactorialNumber(number));
    }
}