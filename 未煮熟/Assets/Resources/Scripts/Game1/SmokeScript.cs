using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeScript : MonoBehaviour
{
    public void SpawnSmoke()
    {
        Debug.Log("dfjdfioh");
        GameObject ClamCooked = Resources.Load<GameObject>("Prefabs/Smoke");
        Instantiate<GameObject>(ClamCooked, transform);
    }
}
