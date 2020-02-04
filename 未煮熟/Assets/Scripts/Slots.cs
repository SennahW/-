using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slots : MonoBehaviour, IDropHandler
{
    public string myWantedItemTag;
    public string myWantedItemTag1;
    public string myWantedItemTag2;

    public GameObject myItem
    {
        get
        {
            if(transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
        
    }

    public void OnDrop(PointerEventData eventData)
    {
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
                //Run animation!!!!
            }
        }
    }
}
