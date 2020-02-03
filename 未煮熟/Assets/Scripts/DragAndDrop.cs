using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool mySelected;

    void Update()
    {
        if(mySelected == true)
        {
            Vector2 myCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(myCursorPos.x, myCursorPos.y);
        }

        if(Input.GetMouseButtonUp(0))
        {
            mySelected = false;
        }
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mySelected = true;
        }
    }
}
