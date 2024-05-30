using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question11 : MonoBehaviour
{
    void Table()
    {
        int temp = 0;
        for(int i = 1; i <= 10; i++)
        {
            temp = i * i;
            Debug.Log(i + " elevado al cuadrado es: " + temp);
        }
    }
    private void Start()
    {
        Table();
    }
}