    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Slots : MonoBehaviour, IDropHandler
{
    public string myWantedItemTag;
    public string myWantedItemTag1;
    public string myWantedItemTag2;

    PointerEventData myEventData;

    public GameObject myItem
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public void Update()
    {
        if (this.tag == "BowlStorage")
        {
            if (transform.childCount < 1)
            {
                GameObject Bowl = Resources.Load<GameObject>("Prefabs/Bowl");
                Instantiate<GameObject>(Bowl, this.transform);
            }
        }

        if (this.tag == "EggStorage")
        {
            if (transform.childCount < 1)
            {
                GameObject Egg = Resources.Load<GameObject>("Prefabs/Egg");
                Instantiate<GameObject>(Egg, this.transform);
            }
        }

        if (this.tag == "LemonStorage")
        {
            if (transform.childCount < 1)
            {
                //GameObject Lemon = Resources.Load<GameObject>("Prefabs/Lemon");
                //Instantiate<GameObject>(Lemon, this.transform);
            }
        }

        if (this.tag == "RiceStorage")
        {
            if (transform.childCount < 1)
            {
                //GameObject Rice = Resources.Load<GameObject>("Prefabs/Rice");
                //Instantiate<GameObject>(Rice, this.transform);
            }
        }

        if (this.tag == "ShrimpStorage")
        {
            if (transform.childCount < 1)
            {
                //GameObject Shrimp = Resources.Load<GameObject>("Prefabs/Shrimp");
                //Instantiate<GameObject>(Shrimp, this.transform);
            }
        }

        if (this.tag == "ClamStorage")
        {
            if (transform.childCount < 1)
            {
                //GameObject Clam = Resources.Load<GameObject>("Prefabs/Clam");
                //Instantiate<GameObject>(Clam, this.transform);
            }
        }

        if (this.tag == "PorkStorage")
        {
            if (transform.childCount < 1)
            {
                //GameObject Pork = Resources.Load<GameObject>("Prefabs/Pork");
                //Instantiate<GameObject>(Pork, this.transform);
            }
        }

        if (this.tag == "GreenOnionStorage")
        {
            if (transform.childCount < 1)
            {
                GameObject GreenOnion = Resources.Load<GameObject>("Prefabs/GreenOnion");
                Instantiate<GameObject>(GreenOnion, this.transform);
            }
        }

        if (tag == "FryingPanOne")
        {
            if (transform.childCount > 0)
            {
                if (transform.GetChild(0).tag == "EggCooked")
                {
                    GetComponent<GridLayoutGroup>().padding.top = -10;
                    Debug.Log(GetComponent<GridLayoutGroup>().padding);
                    LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponentInParent<RectTransform>());
                }
            }
            else
            {
                GetComponent<GridLayoutGroup>().padding.top = 0;
                LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponentInParent<RectTransform>());
            }
        }
        if (tag == "FryingPanTwo")
        {

            if (transform.childCount > 0)
            {
                if (transform.GetChild(0).tag == "EggCooked")
                {
                    GetComponent<GridLayoutGroup>().padding.top = 20;
                    Debug.Log(GetComponent<GridLayoutGroup>().padding);
                    LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponentInParent<RectTransform>());
                }
            }
            else
            {
                GetComponent<GridLayoutGroup>().padding.top = 0;
                LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponentInParent<RectTransform>());
            }
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        myEventData = eventData;
        if (DragHandler.myItemBegingDragged.tag == myWantedItemTag || DragHandler.myItemBegingDragged.tag == myWantedItemTag1 || DragHandler.myItemBegingDragged.tag == myWantedItemTag2)
        {
            if (!myItem)
            {
                DragHandler.myItemBegingDragged.transform.SetParent(transform);
            }
        }
        else if (myWantedItemTag == "")
        {
            if (!myItem)
            {
                DragHandler.myItemBegingDragged.transform.SetParent(transform);
            }
        }

        if (this.tag == "Cuttingboard")
        {
            if (DragHandler.myItemBegingDragged.tag == "GreenOnion")
            {
                var temp = DragHandler.myItemBegingDragged.GetComponent<Animator>();
                temp.SetTrigger("RunChop");
            }
        }

        if (this.tag == "FryingpanOne")
        {
            if (DragHandler.myItemBegingDragged.tag == "Egg")
            {
                var temp = DragHandler.myItemBegingDragged.GetComponent<Animator>();
                temp.SetTrigger("CookEgg");
            }
        }
        if (this.tag == "FryingpanTwo")
        {
            if (DragHandler.myItemBegingDragged.tag == "Egg")
            {
                var temp = DragHandler.myItemBegingDragged.GetComponent<Animator>();
                temp.SetTrigger("CookEggTwo");
            }
        }
}

    public void SpawnChoppenGeenOnion()
    {
        Debug.Log("Spawned");
        GameObject myOnionChop = Resources.Load<GameObject>("Prefabs/GreenOnionChopped");
        Instantiate<GameObject>(myOnionChop, this.transform);
    }

    public void SpawnCookedEgg()
    {
        Debug.Log("SpawnedEggCooked");
        GameObject myEggCooked = Resources.Load<GameObject>("Prefabs/EggCooked");
        Instantiate<GameObject>(myEggCooked, this.transform);

    }
}