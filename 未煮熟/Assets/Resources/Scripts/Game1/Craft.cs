using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Craft : MonoBehaviour
{
    GameObject gameObjectOne;
    GameObject gameObjectThree;
    GameObject gameObjectTwo;
    GameObject gameObjectFour;

    // Update is called once per frame
    void Update()
    {
        gameObjectOne = GameObject.FindGameObjectWithTag("CraftSlotOne");
        gameObjectThree = GameObject.FindGameObjectWithTag("CraftSlotThree");
        gameObjectTwo = GameObject.FindGameObjectWithTag("CraftSlotTwo");
        gameObjectFour = GameObject.FindGameObjectWithTag("CraftYield");


        if (gameObjectOne.transform.childCount > 0)
        {
            if (gameObjectTwo.transform.childCount > 0)
            {
                if (gameObjectThree.transform.childCount > 0)
                {
                    if (gameObjectOne.transform.GetChild(0).tag == "Bowl")
                    {
                        if (gameObjectTwo.transform.GetChild(0).tag == "EggCooked")
                        {
                            if (gameObjectThree.transform.GetChild(0).tag == "GreenOnionChopped")
                            {
                                if (gameObjectFour.transform.childCount == 0)
                                {
                                    GameObject EggRice = Resources.Load<GameObject>("Prefabs/Ris_ägg");
                                    Instantiate<GameObject>(EggRice, gameObjectFour.transform);
                                    DestroyImmediate(gameObjectOne.transform.GetChild(0).gameObject);
                                    DestroyImmediate(gameObjectTwo.transform.GetChild(0).gameObject);
                                    DestroyImmediate(gameObjectThree.transform.GetChild(0).gameObject);
                                }
                            }
                        }
                    }
                }
            }
        }
        else
        {

        }
    }
}
