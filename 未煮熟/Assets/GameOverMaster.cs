using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameOverMaster : MonoBehaviour
{
    public int myScore;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey(" "))
        {
            if(Application.loadedLevel == 2)
            {
                PlayerPrefs.DeleteKey(" ");
                myScore = 0;
            }
            else
            {
                myScore = PlayerPrefs.GetInt(" ");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (" " + myScore);
    }
}
