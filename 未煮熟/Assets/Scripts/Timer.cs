using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI myTimeText;
    TimeSpan myTimeLeft;
    bool myTimerActive;
    float myElapsedTime;
    float myTimerLength = 120;

    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        myTimeText.text = "Time: 00:00:00";
        myTimerActive = true;
    }

    void StartTimer () 
    {
        myTimerActive = true;
        myElapsedTime = 0f;
    }

    void StopTimer () 
    {
        myTimerActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (myTimerActive)
        {
            myElapsedTime += Time.deltaTime;
            myTimeLeft = TimeSpan.FromSeconds(myTimerLength - myElapsedTime);
        }

        if (myElapsedTime >= myTimerLength)
        {
            myTimerActive = false;
        }

        if (myElapsedTime == 55)
        {
            TimerAnimation();
        }

        string tempTimeString = "Time: " + myTimeLeft.ToString("mm' : 'ss'.'ff");
        myTimeText.text = tempTimeString;
    }

    void TimerAnimation()
    {
        myTimeText.fontSize = 35;

    }

}
