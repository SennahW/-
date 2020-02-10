using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class SlotsCustomer : MonoBehaviour, IDropHandler
{
    public string myWantedItemTag;

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
    }

    public void OnDrop(PointerEventData eventData)
    {
        myEventData = eventData;
        if (DragHandler.myItemBegingDragged.tag == myWantedItemTag)
        {
            if (!myItem)
            {
                DragHandler.myItemBegingDragged.transform.SetParent(transform);
            }
        }
    }
}