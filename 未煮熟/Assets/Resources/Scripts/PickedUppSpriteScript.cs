using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PickedUppSpriteScript : MonoBehaviour, IBeginDragHandler, IEndDragHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (this.tag == "GreenOnionChopped")
        {
            Debug.Log("DragginChopped");
            this.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/green_union_hold");

        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (this.tag == "GreenOnionChopped")
        {
            Debug.Log("DroppingChopped");
            this.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/green_union_cut");
            Debug.Log(Resources.Load<Sprite>("Sprites/green_union_cut").name);
        }
    }
}
