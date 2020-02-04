using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{ 
    public static GameObject myItemBegingDragged;
    Vector3 myStartPosition;
    Transform myStartParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        myItemBegingDragged = gameObject;
        myStartPosition = transform.position;
        myStartParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        myItemBegingDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent == myStartParent)
        {
            transform.position = myStartPosition;
        }
        
    }
}
