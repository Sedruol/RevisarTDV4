using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question4 : MonoBehaviour
{
    public int first = 9;
    public int last = 21;
    int quantity = 0;
    int CountMultiples(int x, int y)
    {
        int count = 0;
        for (int i = x; i <= y; i++)
        {
            if (i % 3 == 0)
            {
                count++;
            }
        }
        return count;
    }
    void Start()
    {
        quantity = CountMultiples(first, last);
        Debug.Log("El número de múltiplos de 3 entre " + first + " y " + last + " es: " + quantity);
    }
}