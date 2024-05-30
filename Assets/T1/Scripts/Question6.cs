using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question6 : MonoBehaviour
{
    public int maximun = 11;
    int total = 0;
    int n = 1;
    void Addition(int max)
    {
        while (n <= max)
        {
            if (n % 2 == 0)
            {
                total += n;
            }
            n++;
        }
        Debug.Log("La suma de los números pares hasta " + maximun + " es: " + total);
    }
    void Start()
    {
        Addition(maximun);
    }
}