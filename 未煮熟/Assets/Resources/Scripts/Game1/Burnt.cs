using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Burnt : MonoBehaviour
{
    public float myBurntCounter;
    string mySlot;

    // Update is called once per frame
    void Update()
    {
        if (myBurntCounter >= 2000)
        {
            if (mySlot == "FryingpanOne")
            {
                GetComponent<Animator>().SetTrigger("BurnTwo");
            }

            if (mySlot == "FryingpanTwo")
            {

                GetComponent<Animator>().SetTrigger("BurnOne");

            }
        }

        if (myBurntCounter == 1000)
        {
            if (mySlot == "FryingpanOne")
            {
                GameObject.FindGameObjectWithTag("Fryingpan!").GetComponent<Image>().enabled = true;
            }

            if (mySlot == "FryingpanTwo")
            {
                GameObject.FindGameObjectWithTag("FryingpanTwo!").GetComponent<Image>().enabled = true;
            }
        }

        if (myBurntCounter == 1500)
        {
            if (mySlot == "FryingpanOne")
            {
                GameObject.FindGameObjectWithTag("Fryingpan!").GetComponent<Image>().enabled = false;
            }

            if (mySlot == "FryingpanTwo")
            {
                GameObject.FindGameObjectWithTag("FryingpanTwo!").GetComponent<Image>().enabled = false;
            }
        }
    }
    
    public void AddBurnt(string aTempString)
    {
        mySlot = aTempString;
        myBurntCounter++;
    }
}
