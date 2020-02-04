﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slots : MonoBehaviour, IDropHandler
{
    public GameObject myItem
    {
        get
        {
            if(transform.childCount>0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
        
    }

    public void OnDrop(PointerEventData eventData)
    {
        if(!myItem)
        {
            DragHandler.myItemBegingDragged.transform.SetParent(transform);
        }
    }
}
