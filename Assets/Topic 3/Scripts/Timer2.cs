using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer2 : MonoBehaviour
{
    public TextMeshProUGUI tmpHUD;
    private int number;
    void Awake()
    {
        //InvokeRepeating(funcion que llamaremos, retraso inicial en segundos,
        //intervalo entre cada repeticion en segundos)
        InvokeRepeating("UsingInvokeRepeating", 1, 1);
    }
    private void UsingInvokeRepeating()
    {
        number++;//number=0+1=1 | number=1+1=2 | number=2+1=3
    }
    void Update()
    {
        tmpHUD.text = "Time: " + number.ToString();
    }
}