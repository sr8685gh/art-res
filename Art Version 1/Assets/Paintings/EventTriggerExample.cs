using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventTriggerExample : EventTrigger
{
    float lastClick = 0f;
    float interval = 0.4f;
    public GameObject myObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void OnPointerDown(PointerEventData data)
    {

        if ((lastClick + interval) > Time.time)
        {
            Debug.Log("double click");

        }
        else
        {//is a single click 
        }
        lastClick = Time.time;

    }
}


        
