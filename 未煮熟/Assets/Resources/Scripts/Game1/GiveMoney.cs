
using UnityEngine;
using System;
using TMPro;

public class GiveMoney : MonoBehaviour
{
    public float myMoney;
    public TextMeshProUGUI myScoreText;

    // Update is called once per frame
    void Update()
    {
        string tempMoneyString = myMoney.ToString();
        myScoreText.text = tempMoneyString;
    }

    public void CostumerMoney(float aTimerValue)
    {
        float tempMoney;
        if (aTimerValue > 25)
        {
            tempMoney = 100;
            myMoney += tempMoney;
        }
        else if (aTimerValue > 25)
        {
            tempMoney = 25 * ((25 / aTimerValue) + 1);

            myMoney += tempMoney;
        }
        int rounded = (int)Math.Round(myMoney, 0);
        myMoney = rounded;
    }

}
