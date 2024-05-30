using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question5 : MonoBehaviour
{
    public int serviceYears = 5;
    private float bonus;
    float CalculateBonusYears(int _age)
    {
        if (_age >= 10)
        {
            return 1000f;
        }
        else if (_age >= 5)
        {
            return 500f;
        }
        else
        {
            return 100f;
        }
    }
    void Start()
    {
        bonus = CalculateBonusYears(serviceYears);
        Debug.Log("La bonificación es de $" + bonus);
    }
}