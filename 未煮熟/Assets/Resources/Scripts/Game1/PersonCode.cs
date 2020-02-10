using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonCode : MonoBehaviour
{
    bool Arrivied = false;

    private Vector2 Pos;
    public Vector2 myTargetPos;
    GameObject myFoodPosition;
    int SeatTaken;
    public float speed = 50.0f;

    string[] myOrder;
    public GameObject myOrderImageGameObject;
    public GameObject SlotOne;
    public GameObject SlotTwo;
    public GameObject SlotThree;
    public bool OrderFinished;

    // Start is called before the first frame update
    void Start()
    {
        myOrder = FindOrder.FoodOrder();
        OrderFinished = false;
        myTargetPos = FindCostumerSpot.FindSpot();
        SeatTaken = FindCostumerSpot.Spot;
        Pos = transform.position;

        if (myOrder.Length == 1)
        {
            GetComponentInChildren<SlotsCustomer>().myWantedItemTag = myOrder[0];
        }
    }

    // Update is called once per frame
    private void Update()
    {
        Pos = transform.position;
        float MoveSpeed = speed * Time.deltaTime;
        if (Pos != myTargetPos)
        {
            transform.position = Vector2.MoveTowards(transform.position, myTargetPos, MoveSpeed);
        }

        if (Pos == myTargetPos && OrderFinished == true)
        {
            DestroyImmediate(this.gameObject);
        }

        if (OrderFinished == true)
        {
            FindCostumerSpot.AvailableSpots[SeatTaken] = 0;

            myTargetPos = GameObject.FindGameObjectWithTag("ExitPoint").transform.position;
            //Destroy(SlotOne);
            //Destroy(SlotTwo);
            //Destroy(SlotThree);
            //Destroy(myOrderImageGameObject);
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
                    }
                }
                else if (SlotOne.transform.GetChild(0).tag == myOrder[0] && SlotTwo.transform.GetChild(0).tag == myOrder[1])
                {
                        OrderFinished = true;
                }
            }
            else if (SlotOne.transform.GetChild(0).tag == myOrder[0])
            {
                        OrderFinished = true;
            }
        }

        if (myOrder[0] == "Ris_ägg")
        {
            if (myOrder.Length > 1 && myOrder[1] == "Ris_ägg_pork")
            {
                if (myOrder.Length > 2 && myOrder[2] == "Ris_paella")
                {
                    Debug.Log("Spawn: Risägg, risgris, paella");
                    myOrderImageGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/Orders/talk_bubble_1_2_3");
                }
                else
                {
                    Debug.Log("Rissägg, risgris");
                    myOrderImageGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/Orders/talk_bubble_1_2");
                }
            }
            else if (myOrder.Length > 1 && myOrder[1] == "Ris_paella")
            {
                Debug.Log("Risägg, paella");
                myOrderImageGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/Orders/talk_bubble_1_3");
            }
            else
            {
                Debug.Log("Risägg");
                myOrderImageGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/Orders/talk_bubble_1");
            }
        }

        else if (myOrder[0] == "Ris_ägg_pork")
        {
            if (myOrder.Length > 1 && myOrder[1] == "Ris_paella")
            {
                Debug.Log("Risgris, paella");
                myOrderImageGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/Orders/talk_bubble_2_3");
            }
            else
            {
                Debug.Log("Risgris");
                myOrderImageGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/Orders/talk_bubble_2");
            }
        }

        else if (myOrder[0] == "Ris_paella")
        {
            Debug.Log("paella");
            myOrderImageGameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Game1/Orders/talk_bubble_3");
        }
    }
}
