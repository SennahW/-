﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

static class Extensions
{
    static public bool Between(this float aVar, float aValue, float anOffset)
    {
        if(aVar >= (aValue - anOffset) && aVar <= (aValue + anOffset))
        {
            return true;
        }
        return false;
    }
}

public class PersonCode : MonoBehaviour
{
    private Vector2 Pos;
    public Vector2 position;
    public Vector2 myTargetPos;
    int SeatTaken;
    public float speed = 50.0f;

    string[] myOrder;
    public GameObject myOrderImageGameObject;
    public GameObject Slots;
    public GameObject SlotOne;
    public GameObject SlotTwo;
    public GameObject SlotThree;
    public GameObject Timer;
    public bool OrderFinished;
    public bool TimerFinshed;
    public bool GivenMoney = false;

    public Sprite[] costumers;

    public AudioClip audioTimer;

    float myElapsedTime;

    public Animator myAnimator;
    

    // Start is called before the first frame update
    void Start()
    {
        myOrder = FindOrder.FoodOrder();
        OrderFinished = false;
        myTargetPos = FindCostumerSpot.FindSpot();
        SeatTaken = FindCostumerSpot.Spot;
        Pos = transform.position;
        
        int tempCos = Random.Range(0, costumers.Length);

        GetComponent<Image>().sprite = costumers[tempCos];

    }



    // Update is called once per frame
    private void Update()
    {
        myElapsedTime += Time.deltaTime;
        position = transform.TransformPoint(Vector2.zero);
        Pos = transform.position;
        float MoveSpeed = speed * Time.deltaTime;
        if (Pos != myTargetPos)
        {
            transform.position = Vector2.MoveTowards(transform.position, myTargetPos, MoveSpeed);
        }

        if (position.x.Between(myTargetPos.x, 0.5f) && position.y.Between(myTargetPos.y, 0.5f) && OrderFinished == false)
        {
            myOrderImageGameObject.SetActive(true);
            Timer.SetActive(true);
            Slots.SetActive(true);
            GetComponentInChildren<Animator>().SetTrigger("RunTimer");
            if (myOrder.Length == 1)
            {
                SlotOne.GetComponent<SlotsCustomer>().myWantedItemTag = myOrder[0];
            }
            else if (myOrder.Length == 2)
            {
                SlotOne.GetComponent<SlotsCustomer>().myWantedItemTag = myOrder[0];
                SlotTwo.GetComponent<SlotsCustomer>().myWantedItemTag = myOrder[1];
            }
            else if (myOrder.Length == 3)
            {
                SlotOne.GetComponent<SlotsCustomer>().myWantedItemTag = myOrder[0];
                SlotTwo.GetComponent<SlotsCustomer>().myWantedItemTag = myOrder[1];
                SlotThree.GetComponent<SlotsCustomer>().myWantedItemTag = myOrder[2];
            }
        }
        else
        {
            myOrderImageGameObject.SetActive(false);
            Timer.SetActive(false);
            Slots.SetActive(false);
        }

        if (position.x.Between(myTargetPos.x, 0.5f) && position.y.Between(myTargetPos.y, 0.5f) && OrderFinished == false && TimerFinshed == true)
        {
            GiveMoney.myMoney += -30;
            GameObject.FindGameObjectWithTag("Gamemaster").GetComponent<Lifes>().RemoveLife();           
            CostumerSpawning.timer = 400;
            FindCostumerSpot.AvailableSpots[SeatTaken] = 0;
            CostumerSpawning.CurrentCostumers--;
            Destroy(this.gameObject);
        }

        if (SlotOne.transform.childCount > 0)
        {
            if (SlotTwo.transform.childCount > 0 && myOrder.Length > 1)
            {
                if (SlotThree.transform.childCount > 0 && myOrder.Length > 2)
                {
                    if (SlotOne.transform.GetChild(0).tag == myOrder[0] && SlotTwo.transform.GetChild(0).tag == myOrder[1] && SlotThree.transform.GetChild(0).tag == myOrder[2])
                    {
                        OrderFinished = true;
                        if (GivenMoney == false)
                        {
                            GiveMoney.myMoney += 100;
                            GameObject Coin = Resources.Load<GameObject>("Prefabs/Coin");
                            Instantiate<GameObject>(Coin, this.transform);
                            GivenMoney = true;
                        }
                    }
                }
                else if (SlotOne.transform.GetChild(0).tag == myOrder[0] && SlotTwo.transform.GetChild(0).tag == myOrder[1])
                {
                    OrderFinished = true;
                    if (GivenMoney == false)
                    {
                        GiveMoney.myMoney += 100;
                        GameObject Coin = Resources.Load<GameObject>("Prefabs/Coin");
                        Instantiate<GameObject>(Coin, this.transform);
                        GivenMoney = true;
                    }

                }
            }
            else if (SlotOne.transform.GetChild(0).tag == myOrder[0] && myOrder.Length < 2)
            {
                OrderFinished = true;
                if (GivenMoney == false)
                {
                    GiveMoney.myMoney += 100;
                    GameObject Coin = Resources.Load<GameObject>("Prefabs/Coin");
                    Instantiate<GameObject>(Coin, this.transform);
                    GivenMoney = true;
                }

            }
        }

        if (myOrder[0] == "Ris_ägg")
        {
            if (myOrder.Length > 1 && myOrder[1] == "Ris_ägg_pork")
            {
                if (myOrder.Length > 2 && myOrder[2] == "Ris_paella")
                {
                    myOrderImageGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/Orders/talk_bubble_1_2_3");
                }
                else
                {
                    myOrderImageGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/Orders/talk_bubble_1_2");
                }
            }
            else if (myOrder.Length > 1 && myOrder[1] == "Ris_paella")
            {
                myOrderImageGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/Orders/talk_bubble_1_3");
            }
            else
            {
                myOrderImageGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/Orders/talk_bubble_1");
            }
        }
        else if (myOrder[0] == "Ris_ägg_pork")
        {
            if (myOrder.Length > 1 && myOrder[1] == "Ris_paella")
            {
                myOrderImageGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/Orders/talk_bubble_2_3");
            }
            else
            {
                myOrderImageGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/Orders/talk_bubble_2");
            }
        }
        else if (myOrder[0] == "Ris_paella")
        {
            myOrderImageGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/Orders/talk_bubble_3");
        }

        if (OrderFinished == true)
        {
            FindCostumerSpot.AvailableSpots[SeatTaken] = 0;
            myTargetPos = GameObject.FindGameObjectWithTag("ExitPoint").transform.position;
        }

        if (position.x.Between(GameObject.FindGameObjectWithTag("ExitPoint").transform.position.x, 0.5f) && position.y.Between(GameObject.FindGameObjectWithTag("ExitPoint").transform.position.y, 0.5f) && OrderFinished == true)
        {
            FindCostumerSpot.AvailableSpots[SeatTaken] = 0;
            CostumerSpawning.CurrentCostumers--;
            Destroy(this.gameObject);
        }
    }

   public  void PlayTimer()
    {
        AudioSource audio = gameObject.AddComponent<AudioSource>();
        audio.clip = audioTimer;
        audio.Play();
    }

    public void TimerFinished()
    {
        FindCostumerSpot.AvailableSpots[SeatTaken] = 0;
        myTargetPos = GameObject.FindGameObjectWithTag("ExitPoint").transform.position;

        TimerFinshed = true;
    }
}
