using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class GiveMoney : MonoBehaviour
{
    public static int myMoney;
    private Text myScoreText;

    void Start()
    {       
        myScoreText = GetComponent<Text>();
        myMoney = 0;
    }

    // Update is called once per frame
    void Update()
    {
        myScoreText.text = " " + myMoney;
        //string tempMoneyString = myMoney.ToString();
        //myScoreText.text = tempMoneyString;
    }

    //public void CostumerMoney(float aTimerValue)
    //{
    //    float tempMoney;
    //    if (aTimerValue <= 25)
    //    {
    //        tempMoney = 25 * ((25 / aTimerValue) + 1);

    //        myMoney += tempMoney;
    //    }
    //    else if (aTimerValue > 25)
    //    {
    //        tempMoney = -25 * ((25 / aTimerValue) + 1);

    //        myMoney += tempMoney;
    //    }
    //    int rounded = (int)Math.Round(myMoney, 0);
    //    myMoney = rounded;
    //}

    public void SaveMoney()
    {

    }
}
