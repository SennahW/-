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
    GameObject gameObjectFive;
    GameObject gameObjectSix;
    GameObject gameObjectOut;

    // Update is called once per frame
    void Update()
    {
        gameObjectOne = GameObject.FindGameObjectWithTag("CraftSlotOne");
        gameObjectThree = GameObject.FindGameObjectWithTag("CraftSlotThree");
        gameObjectTwo = GameObject.FindGameObjectWithTag("CraftSlotTwo");
        gameObjectFour = GameObject.FindGameObjectWithTag("CraftSlotFour");
        gameObjectFive = GameObject.FindGameObjectWithTag("CraftSlotFive");
        gameObjectSix = GameObject.FindGameObjectWithTag("CraftSlotSix");
        gameObjectOut = GameObject.FindGameObjectWithTag("CraftYield");


        if (gameObjectOne.transform.childCount > 0)
        {
            if (gameObjectTwo.transform.childCount > 0)
            {
                if (gameObjectThree.transform.childCount > 0)
                {
                    if (gameObjectOne.transform.GetChild(0).tag == "Bowl")
                    {
                        if (gameObjectTwo.transform.GetChild(0).tag == "RiceCooked")
                        {
                            if (gameObjectThree.transform.GetChild(0).tag == "EggCooked")
                            {
                                if (gameObjectFour.transform.GetChild(0).tag == "GreenOnionChopped")
                                {
                                    if (gameObjectOut.transform.childCount == 0)
                                    {
                                        GameObject EggRice = Resources.Load<GameObject>("Prefabs/Ris_ägg");
                                        Instantiate<GameObject>(EggRice, gameObjectOut.transform);
                                        DestroyImmediate(gameObjectOne.transform.GetChild(0).gameObject);
                                        DestroyImmediate(gameObjectTwo.transform.GetChild(0).gameObject);
                                        DestroyImmediate(gameObjectThree.transform.GetChild(0).gameObject);
                                    }
                                }
                            }
                            else if (gameObjectThree.transform.GetChild(0).tag == "PorkCooked")
                            {
                                if (gameObjectFour.transform.GetChild(0).tag == "EggCooked")
                                {
                                    if (gameObjectFive.transform.GetChild(0).tag == "GreenOnionChopped")
                                    {
                                        if (gameObjectOut.transform.childCount == 0)
                                        {
                                            GameObject EggRice = Resources.Load<GameObject>("Prefabs/Ris_ägg_pork");
                                            Instantiate<GameObject>(EggRice, gameObjectOut.transform);
                                            DestroyImmediate(gameObjectOne.transform.GetChild(0).gameObject);
                                            DestroyImmediate(gameObjectTwo.transform.GetChild(0).gameObject);
                                            DestroyImmediate(gameObjectThree.transform.GetChild(0).gameObject);
                                        }
                                    }
                                }
                            }
                            else if (gameObjectTwo.transform.GetChild(0).tag == "Spice")
                            {
                                if (gameObjectOut.transform.childCount == 0 && gameObjectThree.transform.childCount == 0 && gameObjectFour.transform.childCount == 0 && gameObjectFive.transform.childCount == 0 && gameObjectSix.transform.childCount == 0)
                                {
                                    GameObject EggRice = Resources.Load<GameObject>("Prefabs/ris_paella");
                                    Instantiate<GameObject>(EggRice, gameObjectOne.transform);
                                    DestroyImmediate(gameObjectTwo.transform.GetChild(0).gameObject);
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
