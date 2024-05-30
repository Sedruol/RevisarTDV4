using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question1 : MonoBehaviour
{
    public int age = 20;
    void CanVote(int a)
    {
        if (a >= 18)
        {
            Debug.Log("Una persona con " + a + " años puede votar.");
        }
        else
        {
            Debug.Log("Una persona con " + a + " años no puede votar.");
        }
    }
    void Start()
    {
        CanVote(age);
    }
}