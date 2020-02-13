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
    }

    public void SaveMoney()
    {
        PlayerPrefs.SetInt(" ", myMoney);
    }
}
