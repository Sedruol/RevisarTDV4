using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question9 : MonoBehaviour
{
    public int minimunNumber = 5;
    public int maximunNumber = 10;
    int temp = 0;
    int count = 0;
    void CountOddNumbers(int min, int max, int n)
    {
        temp = min;
        while (temp <= max)
        {
            if (temp % 2 != 0)
            {
                n++;
            }
            temp++;
        }
        Debug.Log("La cantidad de números impares desde " + min + " hasta " + max + " es: " + n);
    }
    void Start()
    {
        CountOddNumbers(minimunNumber, maximunNumber, count);
    }
}