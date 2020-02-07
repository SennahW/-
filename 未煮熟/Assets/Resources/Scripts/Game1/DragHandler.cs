using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

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

    public void SpawnOnion()
    {
        GameObject.FindGameObjectWithTag("Cuttingboard").GetComponent<Slots>().SpawnChoppenGeenOnion();
        Destroy(this.gameObject);
    }
    
    public void SpawnCookedEgg()
    {
        Debug.Log("Spawn1");
        GameObject.FindGameObjectWithTag("FryingpanOne").GetComponent<Slots>().SpawnCookedEgg();
        Destroy(this.gameObject);
    }

    public void SpawnCookedEggTwo()
    {
        Debug.Log("Spawn2");
        GameObject.FindGameObjectWithTag("FryingpanTwo").GetComponent<Slots>().SpawnCookedEgg();
        Destroy(this.gameObject);
    }

}
