using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                GameObject Exclamation = Resources.Load<GameObject>("Prefabs/Exclamtion");
                Instantiate<GameObject>(Exclamation, GameObject.FindGameObjectWithTag("FryingpanOne").transform);
            }

            if (mySlot == "FryingpanTwo")
            {
                GameObject Exclamation = Resources.Load<GameObject>("Prefabs/Exclamtion");
                Instantiate<GameObject>(Exclamation, GameObject.FindGameObjectWithTag("FryingpanTwo").transform);
            }
        }
    }
    
    public void AddBurnt(string aTempString)
    {
        mySlot = aTempString;
        myBurntCounter++;
    }
}
