using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindOrder : MonoBehaviour
{
    public GameObject[] Food;
    private static int maxnumbers = 4;
    private static GameObject[] myFood = new GameObject[maxnumbers];

    // Start is called before the first frame update
    void Start()
    {
        maxnumbers = Food.Length;
        

        for (int i = 0; i < Food.Length; i++)
        {
            myFood[i] = Food[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static GameObject FoodOrdered()
    {
        int foodItem = Random.Range(0, maxnumbers);

        return myFood[foodItem];
    }

}
