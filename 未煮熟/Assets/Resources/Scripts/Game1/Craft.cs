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

    void Start()
    {
        gameObjectOne = GameObject.FindGameObjectWithTag("CraftSlotOne");
        gameObjectThree = GameObject.FindGameObjectWithTag("CraftSlotThree");
        gameObjectTwo = GameObject.FindGameObjectWithTag("CraftSlotTwo");
        gameObjectFour = GameObject.FindGameObjectWithTag("CraftSlotFour");
        gameObjectFive = GameObject.FindGameObjectWithTag("CraftSlotFive");
        gameObjectSix = GameObject.FindGameObjectWithTag("CraftSlotSix");
        gameObjectOut = GameObject.FindGameObjectWithTag("CraftYield");
    }

    // Update is called once per frame
    public void Mix()
    {
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
                                        DestroyImmediate(gameObjectFour.transform.GetChild(0).gameObject);
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
                                            DestroyImmediate(gameObjectFour.transform.GetChild(0).gameObject);
                                            DestroyImmediate(gameObjectFive.transform.GetChild(0).gameObject);
                                        }
                                    }
                                }
                            }
                        
                        }
                        else if (gameObjectTwo.transform.GetChild(0).tag == "RiceCookedSpice")
                        {
                            Debug.Log("piuefh");
                            if (gameObjectThree.transform.GetChild(0).tag == "ClamCooked")
                            {
                                Debug.Log("ghGÅUOHgeåoEWIGH");
                                if (gameObjectFour.transform.GetChild(0).tag == "ShrimpCooked")
                                {
                                    Debug.Log("IDOFSÅOIHGÅIOH");
                                    if (gameObjectFive.transform.GetChild(0).tag == "LemonCut")
                                    {
                                        Debug.Log("lofjopeuhfåoighG¨POJG¨+9UG");
                                        GameObject PaellaRice = Resources.Load<GameObject>("Prefabs/Ris_paella");
                                        Instantiate<GameObject>(PaellaRice, gameObjectOut.transform);
                                        DestroyImmediate(gameObjectOne.transform.GetChild(0).gameObject);
                                        DestroyImmediate(gameObjectTwo.transform.GetChild(0).gameObject);
                                        DestroyImmediate(gameObjectThree.transform.GetChild(0).gameObject);
                                        DestroyImmediate(gameObjectFour.transform.GetChild(0).gameObject);
                                        DestroyImmediate(gameObjectFive.transform.GetChild(0).gameObject);
                                        DestroyImmediate(gameObjectSix.transform.GetChild(0).gameObject);
                                    }
                                }
                            }
                        }
                    }
                    

                }
                if (gameObjectOne.transform.GetChild(0).tag == "RiceCooked")
                {
                    if (gameObjectTwo.transform.GetChild(0).tag == "Spice")
                    {
                        GameObject SpiceRice = Resources.Load<GameObject>("Prefabs/RiceCookedSpice");
                        Instantiate<GameObject>(SpiceRice, gameObjectOut.transform);
                        DestroyImmediate(gameObjectOne.transform.GetChild(0).gameObject);
                        DestroyImmediate(gameObjectTwo.transform.GetChild(0).gameObject);
                    }
                }
            }
        }
    }
}