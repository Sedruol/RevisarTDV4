using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer1 : MonoBehaviour
{
    public TextMeshProUGUI tmpHUD;
    private float seconds;
    private int number;
    private int secondsToCount = 1;
    private bool exitTime = false;
    void Update()
    {
        if (!exitTime)
        {
            seconds += Time.deltaTime;//seconds = 1.01, seconds=1.0001
            if (seconds >= secondsToCount)//1.01>=1? Si | 1.0001>=1? Si
            {
                seconds = 0;//seconds=0
                number++;//number=0+1=1 | number=1+1=2
            }
        }
        if (number < 10f)
        {
            tmpHUD.text = "Time: " + number.ToString();
        }
        if (number == 10f)
        {
            exitTime = true;
            tmpHUD.text = "Time: " + number.ToString();
            Debug.Log("hola");
        }
    }
}