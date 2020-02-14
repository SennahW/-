using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindOrder : MonoBehaviour
{
    public int MaxOrder = 3;


    // Start is called before the first frame update
    void Start()
    {
    }

    public static string[] FoodOrder()
    {
        int myOrderLength = Random.Range(1, 4);
        string[] myOrder = new string[ myOrderLength];

        switch (myOrderLength)
        {
            case 1:
                switch (Random.Range(1, 4))
                {
                    case 1:
                        myOrder[0] = "Ris_ägg";
                        break;  
                    case 2:
                        myOrder[0] = "Ris_ägg_pork";
                        break;
                    case 3:
                        myOrder[0] = "Ris_paella";
                        break;
                }
                break;

            case 2:
                switch (Random.Range(1, 4))
                {
                    case 1:
                        myOrder[0] = "Ris_ägg";
                        myOrder[1] = "Ris_ägg_pork";
                        break;
                    case 2:
                        myOrder[0] = "Ris_ägg";
                        myOrder[1] = "Ris_paella";
                        break;
                    case 3:
                        myOrder[0] = "Ris_ägg_pork";
                        myOrder[1] = "Ris_paella";
                        break;
                }
                break;

            case 3:
                myOrder[0] = "Ris_ägg";
                myOrder[1] = "Ris_ägg_pork";
                myOrder[2] = "Ris_paella";
                break;
        }

        return myOrder;
    }

}
