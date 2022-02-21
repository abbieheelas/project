using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{
    float timer;
    float minutes;
    float seconds;
    float milliseconds;

    public UnityEngine.UI.Text stopWatchText;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    void Update()
    {
        makeStopWatch(); 
    }

    void makeStopWatch()
    {
        timer += Time.deltaTime;
        seconds = timer % 60;
        minutes = timer / 60;
        milliseconds = (int)((timer*100) % 100);

        stopWatchText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
    }
}
