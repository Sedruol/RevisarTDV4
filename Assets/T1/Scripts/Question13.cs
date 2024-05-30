using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question13 : MonoBehaviour
{
    public string student = "Pepe";
    public float grade1 = 12.5f;
    public float grade2 = 16;
    public float grade3 = 15;
    void CalcuteFinalGrade(float g1, float g2, float g3, string s)
    {
        float finalGrade = (g1 + g2 + g3) / 3;
        if (finalGrade >= 12.5f)
        {
            Debug.Log(s + " aprobó el curso con un promedio total equivalente a " + finalGrade);
        }
        else
        {
            Debug.Log(s + " desaprobó el curso con un promedio total equivalente a " + finalGrade);
        }
    }
    void Start()
    {
        CalcuteFinalGrade(grade1, grade2, grade3, student);
    }
}