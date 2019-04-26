using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishGame : MonoBehaviour
{
     GameObject[] temp;
    public bool finished = false;
    public GameObject p1, p2, p3, p4, p5, p6, p7, p8, p9;
    // Start is called before the first frame update
    void Start()
    {
        temp = new GameObject[9] { p1, p2, p3, p4, p5, p6, p7, p8, p9 };
    }

    public void Finish() {
        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i].transform.tag.Equals(temp[i].transform.parent.tag))
            {
                temp[i].transform.GetComponent<Image>().color = Color.green;
            }
            else
            {
                temp[i].transform.GetComponent<Image>().color = Color.red;
            }
            temp[i].GetComponent<CanvasGroup>().blocksRaycasts = false;
        }

        finished = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void quitGame() {
        Application.Quit();
    }
}
