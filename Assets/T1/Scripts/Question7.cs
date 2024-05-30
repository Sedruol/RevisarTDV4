using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Question7 : MonoBehaviour
{
    public TextMeshProUGUI timerTMP;
    public float timer = 120f;
    private int minutes = 0;
    private int seconds = 0;
    private bool exitTime = false;
    void Update()
    {
        if (!exitTime)
        {
            timer -= Time.deltaTime;
            minutes = Mathf.FloorToInt(timer / 60);
            seconds = Mathf.FloorToInt(timer % 60);
        }
        if (minutes > 0 || seconds > 0)
        {
            timerTMP.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }
        else if (minutes == 0 && seconds == 0)
        {
            exitTime = true;
            timerTMP.text = minutes.ToString("00") + ":" + seconds.ToString("00");
            Debug.Log("Se acabó el tiempo");
        }
    }
}
