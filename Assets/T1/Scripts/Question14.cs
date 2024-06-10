using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question14 : MonoBehaviour
{
    public int number1 = 3;
    public int number2 = 5;
    int result1;
    int result2;
    int result;
    int CalculateFactorialNumber(int n)
    {
        int temp = 1;
        for (int i = 1; i <= n; i++)
        {
            temp *= i;
        }
        return temp;
    }
    void Start()
    {
        result1 = CalculateFactorialNumber(number1);
        result2 = CalculateFactorialNumber(number2);
        result = result1 + result2;
        Debug.Log(number1 + "! + " + number2 + "! = " + result);
    }
}