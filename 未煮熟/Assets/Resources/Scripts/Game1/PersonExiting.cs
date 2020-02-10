using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonExiting : MonoBehaviour
{

    public GameObject ExitPoint;
    public static Vector2 Exit;
    public static bool foodGotten = false;

    // Start is called before the first frame update
    void Start()
    {
        Exit = ExitPoint.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
