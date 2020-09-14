using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManger : MonoBehaviour
{
    public Quiz_artnumber button;
    string s;
    string clear = "441055441055001663382233822";
    // Start is called before the first frame update
    void Start()
    {
        button = null;
        int i = 0;
        foreach (Transform child in transform)
        {

            child.GetComponent<Quiz_artnumber>().widths = i;
            i++;
        }
    }
   public void Clear()
    {
        s = "";
        foreach (Transform child in transform)
        {

            s+=child.GetComponent<Quiz_artnumber>().number;
        }
       
        if (s == clear)
        {
            Debug.Log("대체 뭔짓을하면 이런퍼즐을 만들어주는거야");
        }
    }

    public void buttonup(int i)
    {
        if (i - 5>0 && i-5!=4)
        {
            transform.GetChild(i - 5).GetComponent<Quiz_artnumber>().buring();
        }

        if(i%5!=0 && i-1!=20 && i - 1 != 0)
        {
            transform.GetChild(i - 1).GetComponent<Quiz_artnumber>().buring();
        }

        if(i%5!=4 && i+1!=4&& i + 1 != 24)
        {
            transform.GetChild(i + 1).GetComponent<Quiz_artnumber>().buring();
        }
        if (i + 5 < 24 && i + 5 != 20)
        {
            transform.GetChild(i + 5).GetComponent<Quiz_artnumber>().buring();
        }

    }
    public void buttondown(int i)
    {
        if (i - 5 > 0 && i - 5 != 4)
        {
            transform.GetChild(i - 5).GetComponent<Quiz_artnumber>().Exits();
        }
        if (i % 5 != 0 && i - 1 != 20 && i - 1 != 0)
        {
            transform.GetChild(i - 1).GetComponent<Quiz_artnumber>().Exits();
        }

        if (i % 5 != 4 && i + 1 != 4 && i + 1 != 24)
        {
            transform.GetChild(i + 1).GetComponent<Quiz_artnumber>().Exits();
        }
        if (i + 5 < 24 && i + 5 != 20)
        {
            transform.GetChild(i + 5).GetComponent<Quiz_artnumber>().Exits();
        }
    }
    // Update is called once per frame

}
