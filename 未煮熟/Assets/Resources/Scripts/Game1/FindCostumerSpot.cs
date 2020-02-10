using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindCostumerSpot : MonoBehaviour
{
    public static int[] AvailableSpots = new int[6];
    public GameObject spot1;
    public GameObject spot2;
    public GameObject spot3;
    public GameObject spot4;
    public GameObject spot5;
    public static Vector2 Seat1;
    public static Vector2 Seat2;
    public static Vector2 Seat3;
    public static Vector2 Seat4;
    public static Vector2 Seat5;
    public static int Spot;
    

    // Start is called before the first frame update
    void Start()
    {
        Seat1 = spot1.transform.position;
        Seat2 = spot2.transform.position;
        Seat3 = spot3.transform.position;
        Seat4 = spot4.transform.position;
        Seat5 = spot5.transform.position;

    }

    public static Vector2 FindSpot()
    {
        Spot = Random.Range(1, 6);
        Vector2 tempPosition = new Vector2();
        switch (Spot)
        {
            case 1:
                if (AvailableSpots[1] == 0)
                {
                   tempPosition  = Seat1;
                    AvailableSpots[1] = 1;
                }
                else return FindSpot();
                break;

            case 2:
                if (AvailableSpots[2] == 0)
                {
                    tempPosition = Seat2;
                    AvailableSpots[2] = 1;
                }
                else return FindSpot();
                break;

            case 3:
                if (AvailableSpots[3] == 0)
                {
                    tempPosition = Seat3;
                    AvailableSpots[3] = 1;
                }
                else return FindSpot();
                break;

            case 4:
                if (AvailableSpots[4] == 0)
                {
                    tempPosition = Seat4;
                    AvailableSpots[4] = 1;
                }
                else return FindSpot();
                break;
               
            case 5:
                if (AvailableSpots[5] == 0)
                {
                    tempPosition = Seat5;
                    AvailableSpots[5] = 1;
                }
                else return FindSpot();
                break;
        }
        return tempPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
