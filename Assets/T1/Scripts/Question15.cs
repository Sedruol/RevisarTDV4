using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question15 : MonoBehaviour
{
    public string text = "Hola Mundo";
    public int repeat = 10;
    void RepeatText(string t, int r)
    {
        while (r > 0)
        {
            Debug.Log(t);
            r--;
        }
    }
    void Start()
    {
        RepeatText(text, repeat);
    }
}