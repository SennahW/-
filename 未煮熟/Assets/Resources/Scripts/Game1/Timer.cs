using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI myTimeText;
    public Animator myAnimator;
    TimeSpan myTimeLeft;
    bool myTimerActive;
    float myElapsedTime;
    float myTimerLength = 120;
    float myElapsedTimeFloat;

    public Animator myAnimatordsds;

    public AudioClip audioTimer;

    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        myTimeText.text = "Time: 00:00:00";
        myTimerActive = true;
        if (this.gameObject.tag == "Customer")
        {
        }
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
            myElapsedTimeFloat = myTimerLength - myElapsedTime;
        }

        if (myElapsedTime == 100)
        {
            playTimer();
        }

        if (myElapsedTime >= myTimerLength)
        {
            myTimerActive = false;
        }

        if (myElapsedTimeFloat < 110f && myElapsedTimeFloat > 108f)
        {
            TimerAnimation(1);
        }
        string tempTimeString = "Time: " + myTimeLeft.ToString("mm' : 'ss'.'ff");
        myTimeText.text = tempTimeString;
    }

    void TimerAnimation(float aAnimationID)
    {
        if (aAnimationID == 1)
        {
            myAnimator.SetTrigger("DoPop");
            //  Handheld.Vibrate();
        }
    }

    void playTimer()
    {
        AudioSource audio = gameObject.AddComponent<AudioSource>();
        audio.clip = audioTimer;

        audio.Play();
    }

        public float AccessMyElasped { get => myElapsedTime; set => myElapsedTime = value; }
}