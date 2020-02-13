using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burnt : MonoBehaviour
{
    public float myBurntCounter;


    // Update is called once per frame
    void Update()
    {
        if (myBurntCounter >= 2000)
        {
            if (GameObject.FindGameObjectWithTag("FryingpanOne").transform.childCount > 0)
            {
                if (GameObject.FindGameObjectWithTag("FryingpanOne").transform.GetChild(0).tag == "ShrimpCooked" || GameObject.FindGameObjectWithTag("FryingpanOne").transform.GetChild(0).tag == "PorkCooked" || GameObject.FindGameObjectWithTag("FryingpanOne").transform.GetChild(0).tag == "EggCooked")
                {
                    GetComponent<Animator>().SetTrigger("BurnOne");
                }
            }

            if (GameObject.FindGameObjectWithTag("FryingpanTwo").transform.childCount > 0)
            {
                if (GameObject.FindGameObjectWithTag("FryingpanTwo").transform.GetChild(0).tag == "ShrimpCooked" || GameObject.FindGameObjectWithTag("FryingpanTwo").transform.GetChild(0).tag == "PorkCooked" || GameObject.FindGameObjectWithTag("FryingpanTwo").transform.GetChild(0).tag == "EggCooked")
                {
                    GetComponent<Animator>().SetTrigger("BurnTwo");
                }
            }
        }
    }
    
    public void AddBurnt()
    {
        myBurntCounter++;
    }
}
