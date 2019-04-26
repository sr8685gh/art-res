using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragObject : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler,IDropHandler
{
    public Transform parentToReturnTo;
    public GameObject s1, s2, s3, s4, s5, s6, s7, s8, s9;
    public GameObject[] obArr;
    GameObject returnTo;
    bool finishTheGame = false;


    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!finishTheGame)
        {
            parentToReturnTo = transform.parent;
            this.transform.SetParent(transform.parent.parent);
            transform.parent.parent.SetAsLastSibling();
            transform.parent.SetAsLastSibling();
        }
        
        
        
      

    }

    public void OnDrag(PointerEventData eventData)
    {
        if (transform.GetComponent<CanvasGroup>().blocksRaycasts == true)
        {
            transform.position = eventData.position;

        }
     


    }

    public void OnDrop(PointerEventData eventData)
    {

        parentToReturnTo = returnTo.transform;


        for (int i = 0; i < obArr.Length; i++)
        {
            float distance = Vector2.Distance(gameObject.transform.position, obArr[i].transform.position);
           
            if (distance < 50)
            {
                gameObject.transform.position = obArr[i].transform.position;
                parentToReturnTo = obArr[i].transform;
            
                if (obArr[i].transform.childCount == 1)
                {
                    parentToReturnTo = returnTo.transform;
                }
            }
            
           





        }



    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(parentToReturnTo);
        transform.SetAsFirstSibling();
    }

   

    // Start is called before the first frame update
    void Start()
    {obArr= new GameObject[9];
        obArr[0] = s1;
        obArr[1] = s2;
        obArr[2] = s3;
        obArr[3] = s4;
        obArr[4] = s5;
        obArr[5] = s6;
        obArr[6] = s7;
        obArr[7] = s8;
        obArr[8] = s9;

   

        returnTo = GameObject.Find("PaintPanel");

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    }

