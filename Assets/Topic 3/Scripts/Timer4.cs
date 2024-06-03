using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
public class Timer4 : MonoBehaviour
{
    public TextMeshProUGUI tmpHUD;
    private DateTime time;
    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
    void Update()
    {
        time = DateTime.Now;
        string hour = LeadingZero(time.Hour);
        string minute = LeadingZero(time.Minute);
        string second = LeadingZero(time.Second);
        tmpHUD.text = hour + ":" + minute + ":" + second;
    }
}