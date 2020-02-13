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
    float myBurntCounter;

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

    public void SpawnLemon()
    {
        GameObject.FindGameObjectWithTag("Cuttingboard").GetComponent<Slots>().SpawnChoppedLemon();
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

    //public void SpawnCookekPorkOne()
    //{
    //    Debug.Log("Spawn1");
    //    GameObject.FindGameObjectWithTag("FryingpanOne").GetComponent<Slots>().SpawnCookedPork();
    //    Destroy(this.gameObject);
    //}

    //public void SpawnCookekPorkTwo()
    //{
    //    Debug.Log("Spawn1");
    //    GameObject.FindGameObjectWithTag("FryingpanOne").GetComponent<Slots>().SpawnCookedPork();
    //    Destroy(this.gameObject);
    //}

    public void SpawnCookedRiceOne()
    {
        GameObject.FindGameObjectWithTag("PotOne").GetComponent<Slots>().SpawnCookedRice();
        Destroy(this.gameObject);
    }

    public void SpawnCookedRiceTwo()
    {
        GameObject.FindGameObjectWithTag("PotTwo").GetComponent<Slots>().SpawnCookedRice();
        Destroy(this.gameObject);
    }

    public void SpawnCookedPorkOne()
    {
        GameObject.FindGameObjectWithTag("FryingpanOne").GetComponent<Slots>().SpawnCookedPork();
        Destroy(this.gameObject);
    }

    public void SpawnCookedPorkTwo()
    {
        GameObject.FindGameObjectWithTag("FryingpanTwo").GetComponent<Slots>().SpawnCookedPork();
        Destroy(this.gameObject);
    }

    public void SpawnCookedShrimpOne()
    {
        GameObject.FindGameObjectWithTag("FryingpanOne").GetComponent<Slots>().SpawnCookedShrimp();
        Destroy(this.gameObject);
    }

    public void SpawnCookedShrimpTwo()
    {
        GameObject.FindGameObjectWithTag("FryingpanTwo").GetComponent<Slots>().SpawnCookedShrimp();
        Destroy(this.gameObject);
    }

    public void SpawnCookedClamOne()
    {
        GameObject.FindGameObjectWithTag("PotOne").GetComponent<Slots>().SpawnCookedClams();
        Destroy(this.gameObject);
    }

    public void SpawnCookedClamTwo()
    {
        GameObject.FindGameObjectWithTag("PotTwo").GetComponent<Slots>().SpawnCookedClams();
        Destroy(this.gameObject);
    }

    public void SpawnBurntPorktOne()
    {
        GameObject.FindGameObjectWithTag("FryingpanOne").GetComponent<Slots>().SpawnBurntPork();
        Destroy(this.gameObject);
    }

    public void SpawnBurntPorktTwo()
    {
        GameObject.FindGameObjectWithTag("FryingpanTwo").GetComponent<Slots>().SpawnBurntPork();
        Destroy(this.gameObject);
    }

    public void SpawnBurntShrimpOne()
    {
        GameObject.FindGameObjectWithTag("FryingpanOne").GetComponent<Slots>().SpawnBurntShrimp();
        Destroy(this.gameObject);
    }

    public void SpawnBurntShrimpTwo()
    {
        GameObject.FindGameObjectWithTag("FryingpanTwo").GetComponent<Slots>().SpawnBurntShrimp();
        Destroy(this.gameObject);
    }

    public void SpawnBurntEggOne()
    {
        GameObject.FindGameObjectWithTag("FryingpanOne").GetComponent<Slots>().SpawnBurntEgg();
        Destroy(this.gameObject);
    }

    public void SpawnBurntEggTwo()
    {
        GameObject.FindGameObjectWithTag("FryingpanTwo").GetComponent<Slots>().SpawnBurntEgg();
        Destroy(this.gameObject);
    }
}
