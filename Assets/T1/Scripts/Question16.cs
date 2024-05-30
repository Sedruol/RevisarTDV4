using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question16 : MonoBehaviour
{
    void Table()
    {
        int temp = 0;
        int i = 1;
        while (i <= 10)
        {
            temp = i * i * i;
            Debug.Log(i + " elevado al cubo es: " + temp);
            i++;
        }
    }
    private void Start()
    {
        Table();
    }
}