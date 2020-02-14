using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraPatience : MonoBehaviour
{
    GameObject[] myCustomer;
    int myPrice = 300;

    public void AddExtraTime()
    {
        if (GiveMoney.myMoney >= myPrice)
        {
            myCustomer = GameObject.FindGameObjectsWithTag("CustomerTimer");
            GiveMoney.myMoney -= myPrice;
            for (int i = 0; i < myCustomer.Length; i++)
            {
                myCustomer[i].GetComponent<Animator>().CrossFade("RunTimer", 0, 0, 0);
            }
        }
    }
}
