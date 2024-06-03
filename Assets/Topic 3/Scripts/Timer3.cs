using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer3 : MonoBehaviour
{
    public TextMeshProUGUI tmpHUD;
    private float timer;
    private int minutes;
    private int seconds;
    void Update()
    {
        timer += Time.deltaTime;
        minutes = Mathf.FloorToInt(timer / 60);//5,4=5 | 8,9 = 8
        //65 segundos->65/60=1,...->minutes=1 | 185 segundos->185/60=3,...->minutes=3
        seconds = Mathf.FloorToInt(timer % 60);//32 % 60 = 32 | 75 % 60 = 15
        tmpHUD.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}