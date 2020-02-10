using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GiveMoney : MonoBehaviour
{
    public static float myMoney;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CostumerMoney()
    {
        float tempMoney;

        if (GetComponent<Timer>().AccessMyElasped > 25)
        {
            tempMoney = 100;
            myMoney += tempMoney;
        }
        else if (GetComponent<Timer>().AccessMyElasped > 25)
        {
            tempMoney = 25 * ((25 / GetComponent<Timer>().AccessMyElasped) + 1);

            myMoney += tempMoney;
        }
        int rounded = (int)Math.Round(myMoney, 0);

    }

}
