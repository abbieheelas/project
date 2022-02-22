using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StopWatch : MonoBehaviour
{
    float timer;
    float minutes;
    float seconds;
    float milliseconds;

    public TextMeshProUGUI stopWatchText;

    // Start is called before the first frame update
    void Start()
    {
        stopWatchText = GetComponent<TextMeshProUGUI>();
        timer = 0;
    }

    //update called every frame
    void Update()
    {
        makeStopWatch(); 
    }
    //calculates the values for the stopwatch
    void makeStopWatch()
    {
        timer += Time.deltaTime;
        seconds = Mathf.FloorToInt(timer % 60); //60 seconds per minute
        minutes = Mathf.FloorToInt(timer / 60); //60 minutes per hour
        milliseconds = Mathf.FloorToInt((int)((timer*100) % 100));

        stopWatchText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
        //adds all variables together to display minutes, seconds and milliseconds elapsed
    }
}
