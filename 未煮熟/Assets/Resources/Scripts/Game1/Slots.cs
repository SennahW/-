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

    public AudioClip Frying;
    public AudioClip Boiling;
    public AudioClip Cutting;

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
                GameObject Lemon = Resources.Load<GameObject>("Prefabs/Lemon");
                Instantiate<GameObject>(Lemon, this.transform);
            }
        }

        if (this.tag == "RiceStorage")
        {
            if (transform.childCount < 1)
            {
                GameObject Rice = Resources.Load<GameObject>("Prefabs/Rice");
                Instantiate<GameObject>(Rice, this.transform);
            }
        }

        if (this.tag == "ShrimpStorage")
        {
            if (transform.childCount < 1)
            {
                GameObject Shrimp = Resources.Load<GameObject>("Prefabs/Shrimp");
                Instantiate<GameObject>(Shrimp, this.transform);
            }
        }

        if (this.tag == "ClamStorage")
        {
            if (transform.childCount < 1)
            {
                GameObject Clam = Resources.Load<GameObject>("Prefabs/Clams");
                Instantiate<GameObject>(Clam, this.transform);
            }
        }

        if (this.tag == "PorkStorage")
        {
            if (transform.childCount < 1)
            {
                GameObject Pork = Resources.Load<GameObject>("Prefabs/Pork");
                Instantiate<GameObject>(Pork, this.transform);
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
        if (this.tag == "SpiceStorage")
        {
            if (transform.childCount < 1)
            {
                GameObject GreenOnion = Resources.Load<GameObject>("Prefabs/Spice");
                Instantiate<GameObject>(GreenOnion, this.transform);
            }
        }

        if (this.tag == "FryingpanOne" || this.tag == "FryingpanTwo")
        {
            if (gameObject.transform.childCount > 0)
            {
                if (gameObject.transform.GetChild(0).tag == "PorkCooked" || gameObject.transform.GetChild(0).tag == "ShrimpCooked" || gameObject.transform.GetChild(0).tag == "EggCooked")
                {
                    gameObject.transform.GetChild(0).GetComponent<Burnt>().AddBurnt(this.tag);
                }
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
                PlayCuttingAudio();

            }
            else if (DragHandler.myItemBegingDragged.tag == "Lemon")
            {
                var temp = DragHandler.myItemBegingDragged.GetComponent<Animator>();
                temp.SetTrigger("RunChop");
                PlayCuttingAudio();

            }
        }

        if (this.tag == "FryingpanOne")
        {
            if (DragHandler.myItemBegingDragged.tag == "Egg")
            {
                PlayFryingAudio();

                var temp = DragHandler.myItemBegingDragged.GetComponent<Animator>();
                temp.SetTrigger("CookEgg");
            }
            if (DragHandler.myItemBegingDragged.tag == "Pork")
            {
                PlayFryingAudio();
                var temp = DragHandler.myItemBegingDragged.GetComponent<Animator>();
                temp.SetTrigger("CookPork");
            }
            if (DragHandler.myItemBegingDragged.tag == "Shrimp")
            {
                PlayFryingAudio();

                var temp = DragHandler.myItemBegingDragged.GetComponent<Animator>();
                temp.SetTrigger("CookShrimpOne");
            }
        }
        //
        if (this.tag == "FryingpanTwo")
        {
            if (DragHandler.myItemBegingDragged.tag == "Egg")
            {
                PlayFryingAudio();

                var temp = DragHandler.myItemBegingDragged.GetComponent<Animator>();
                temp.SetTrigger("CookEggTwo");
            }
            if (DragHandler.myItemBegingDragged.tag == "Pork")
            {
                PlayFryingAudio();

                var temp = DragHandler.myItemBegingDragged.GetComponent<Animator>();
                temp.SetTrigger("CookPorkTwo");
            }
            if (DragHandler.myItemBegingDragged.tag == "Shrimp")
            {
                PlayFryingAudio();

                var temp = DragHandler.myItemBegingDragged.GetComponent<Animator>();
                temp.SetTrigger("CookShrimpTwo");
            }
        }

        if (this.tag == "PotOne")
        {
            if (DragHandler.myItemBegingDragged.tag == "Rice")
            {
                PlayBoilingAudio();

                var temp = DragHandler.myItemBegingDragged.GetComponent<Animator>();
                temp.SetTrigger("CookRice");
            }
            else if (DragHandler.myItemBegingDragged.tag == "Clams")
            {
                PlayBoilingAudio();

                var temp = DragHandler.myItemBegingDragged.GetComponent<Animator>();
                temp.SetTrigger("CookClam");
            }
        }
        if (this.tag == "PotTwo")
        {
            if (DragHandler.myItemBegingDragged.tag == "Rice")
            {
                PlayBoilingAudio();

                var temp = DragHandler.myItemBegingDragged.GetComponent<Animator>();
                temp.SetTrigger("CookRiceTwo");
            }
            else if (DragHandler.myItemBegingDragged.tag == "Clams")
            {
                PlayBoilingAudio();

                var temp = DragHandler.myItemBegingDragged.GetComponent<Animator>();
                temp.SetTrigger("CookClamTwo");
            }
        }


        if (tag == "Trash")
        {
            DestroyImmediate(DragHandler.myItemBegingDragged);
        }
    }

    void PlayCuttingAudio()
    {

        AudioSource audio = gameObject.AddComponent<AudioSource>();
        audio.clip = Cutting;
        audio.Play();
    }

    void PlayBoilingAudio()
    {
        AudioSource audio = gameObject.AddComponent<AudioSource>();
        audio.clip = Boiling;
        audio.Play();
    }

    void PlayFryingAudio()
    {
        AudioSource audio = gameObject.AddComponent<AudioSource>();
        audio.clip = Frying;
        audio.Play();
    }

    public void SpawnChoppenGeenOnion()
    {
        Debug.Log("Spawned");
        GameObject myOnionChop = Resources.Load<GameObject>("Prefabs/GreenOnionChopped");
        Instantiate<GameObject>(myOnionChop, this.transform);
    }

    public void SpawnChoppedLemon()
    {
        GameObject myLemonChopped = Resources.Load<GameObject>("Prefabs/LemonCut");
        Instantiate<GameObject>(myLemonChopped, this.transform);
    }

    public void SpawnCookedEgg()
    {
        Debug.Log("SpawnedEggCooked");
        GameObject myEggCooked = Resources.Load<GameObject>("Prefabs/EggCooked");
        Instantiate<GameObject>(myEggCooked, this.transform);
    }

    public void SpawnCookedRice()
    {
        GameObject RiceCooked = Resources.Load<GameObject>("Prefabs/RiceCooked");
        Instantiate<GameObject>(RiceCooked, this.transform);
    }

    public void SpawnCookedPork()
    {
        GameObject PorkCooked = Resources.Load<GameObject>("Prefabs/PorkCooked");
        Instantiate<GameObject>(PorkCooked, this.transform);
    }

    public void SpawnCookedShrimp()
    {
        GameObject ShrimpCooked = Resources.Load<GameObject>("Prefabs/ShrimpCooked");
        Instantiate<GameObject>(ShrimpCooked, this.transform);
    }

    public void SpawnCookedClams()
    {
        GameObject ClamCooked = Resources.Load<GameObject>("Prefabs/ClamsCooked");
        Instantiate<GameObject>(ClamCooked, this.transform);
    }

    public void SpawnBurntPork()
    {
        GameObject ClamCooked = Resources.Load<GameObject>("Prefabs/PorkBurnt");
        Instantiate<GameObject>(ClamCooked, this.transform);
    }

    public void SpawnBurntShrimp()
    {
        GameObject ClamCooked = Resources.Load<GameObject>("Prefabs/ShrimpBurnt");
        Instantiate<GameObject>(ClamCooked, this.transform);
    }

    public void SpawnBurntEgg()
    {
        GameObject ClamCooked = Resources.Load<GameObject>("Prefabs/EggBurnt");
        Instantiate<GameObject>(ClamCooked, this.transform);
    }
}