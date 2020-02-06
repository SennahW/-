using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreTable : MonoBehaviour
{
    private Transform myEntryContainer;
    private Transform myEntryTemplate;

    private void Awake()
    {
        myEntryContainer = transform.Find("highscoreEntryContainer");
        myEntryTemplate = myEntryContainer.Find("highscoreEntryTemplate");

        myEntryTemplate.gameObject.SetActive(false);

        float myTemplateHeight = 20f;
        for(int i = 0; i < 10; i++)
        {
            Transform myEntryTransform = Instantiate(myEntryTemplate, myEntryContainer);
            RectTransform myEntryRectTransform = myEntryTransform.GetComponent<RectTransform>();
            myEntryRectTransform.anchoredPosition = new Vector2(0, -myTemplateHeight * i);
            myEntryTransform.gameObject.SetActive(true);

            int rank = i + 1;
            string rankString;
            switch (rank)
            {
                default:
                    rankString = rank + "TH"; break;

                case 1: rankString = "1ST"; break;
                case 2: rankString = "2AD"; break;
                case 3: rankString = "3RD"; break;
            }

            myEntryTransform.Find("posText").GetComponent<Text>().text = rankString;

            int score = Random.Range(0, 10000);

            myEntryTransform.Find("scoreText").GetComponent<Text>().text = score.ToString();

            string name = "AAA";
            myEntryTransform.Find("nameText").GetComponent<Text>().text = name;
        }
    }
}
