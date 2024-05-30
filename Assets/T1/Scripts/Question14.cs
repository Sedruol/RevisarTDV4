using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question14 : MonoBehaviour
{
    public int number1 = 3;
    public int number2 = 5;
    void CalculateFactorialNumber(int n1, int n2)
    {
        int result1 = 1;
        int result2 = 1;
        int result = 0;
        for (int i = 1; i <= n1; i++)
        {
            result1 *= i;
        }
        for (int j = 1; j <= n2; j++)
        {
            result2 *= j;
        }
        result = result1 + result2;
        Debug.Log(number1 + "! + " + number2 + "! = " + result);
    }
    void Start()
    {
        CalculateFactorialNumber(number1, number2);
    }
}