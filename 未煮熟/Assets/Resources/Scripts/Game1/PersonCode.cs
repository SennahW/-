using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonCode : MonoBehaviour
{
    private bool Arrivied = false;

    public GameObject myPosition;
    private Vector2 Pos;
    private Vector2 myTargetPos;
    public GameObject myFoodPosition;
    public int SeatTaken;
    public float speed = 5.0f;
    private static GameObject FoodIWant;
    private static Vector2 FoodPos;
    private bool OrderDone = false;
    
    // Start is called before the first frame update
    void Start()
    {
        OrderDone = false;
        myTargetPos = FindCostumerSpot.FindSpot();
        SeatTaken = FindCostumerSpot.Spot;
        Pos = myPosition.transform.position;
        FoodPos = myFoodPosition.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        Pos = myPosition.transform.position;
        float MoveSpeed = speed * Time.deltaTime;
        if (Pos != myTargetPos)
        {
            transform.position = Vector2.MoveTowards(transform.position, myTargetPos, MoveSpeed);
        }
        else if (Pos == myTargetPos && OrderDone == false)
        {
            FoodIWant = FindOrder.FoodOrdered();
            Instantiate(FoodIWant, myFoodPosition.transform);
            OrderDone = true;
            transform.position = new Vector2(myTargetPos.x, myTargetPos.y + 0.1f);
        }
        if (PersonExiting.foodGotten == true)
        {
            FindCostumerSpot.AvailableSpots[SeatTaken] = 0;
            
            transform.position = Vector2.MoveTowards(transform.position, PersonExiting.Exit, MoveSpeed);
        }
    }
}
