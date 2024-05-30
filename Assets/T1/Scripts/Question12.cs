using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question12 : MonoBehaviour
{
    public int first = 1;
    public int last = 100;
    void CountMultiples(int x, int y)
    {
        int count = 0;
        for (int i = x; i <= y; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                count++;
            }
        }
        Debug.Log("El número de múltiplos de 3 y 5 a la vez, entre " + x + " y " + y + " es: " + count);
    }
    void Start()
    {
        CountMultiples(first, last);
    }
}