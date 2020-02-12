using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lifes : MonoBehaviour
{
    public GameObject LifeOne;
    public GameObject LifeTwo;
    public GameObject LifeThree;

    public float myCounter;

    // Start is called before the first frame update
    void Start()
    {
        LifeOne = GameObject.FindGameObjectWithTag("LifeOne");
        LifeTwo = GameObject.FindGameObjectWithTag("LifeTwo");
        LifeThree = GameObject.FindGameObjectWithTag("LifeThree");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RemoveLife()
    {
        if (myCounter == 0)
        {
            LifeOne.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/lives_failed");
        }
        else if (myCounter == 1)
        {
            LifeTwo.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/lives_failed");
        }
        else if (myCounter == 2)
        {
            LifeThree.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/lives_failed");
        }
        else if (myCounter >= 3)
        {
            SceneManager.LoadScene(3);
        }
        myCounter++;
    }
}
