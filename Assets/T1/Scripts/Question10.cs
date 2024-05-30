using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question10 : MonoBehaviour
{
    public int number = 8;
    void Table(int n)
    {
        int temp = 0;
        int i = 1;
        while (i <= 20)
        {
            temp = n * i;
            Debug.Log(n + " x " + i + " = " + temp);
            i++;
        }
    }
    private void Start()
    {
        Table(number);
    }
}