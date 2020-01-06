using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private const float startTime = 1f;
    
    public FloatVariable timer;
    public TextMeshProUGUI timerText;
    
    private void Awake()
    {
        timer.value = startTime;
    }
    
    private void Update()
    {
        timerText.text = timer.value.ToString("0");
        
        if (timer.value > 0)
        {
            timer.value -= Time.deltaTime;
        }
        else
        {
            timer.value = startTime;
        }
        
    }
}
