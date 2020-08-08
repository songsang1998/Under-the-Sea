using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Itemon : MonoBehaviour
{
    // Start is called before the first frame update
    Sensing GM;

    public void Start()
    {
        GM=GameObject.Find("GameManager").GetComponent<Sensing>();
    }
    // Update is called once per frame
    
    public void ItemOn()
        {
            string s = transform.parent.name;
            Transform g= transform.parent.parent;
            string y = gameObject.name.Replace("(Clone)", "");
            
        if (GM.item == y)
        {
            for (int i = 0; i < 6;i++) { 
            if (g.GetChild(i).name == s)
                    {
                        g.GetChild(i).GetComponent<Image>().color = Color.white;
                        GM.item = "없음";
                        GM.itemnumber = -1;
                    break;
                    }
            }
        }
        else
        {
            for (int i = 0; i < 6; i++)
            {
                if (g.GetChild(i).name == s)
                {
                    g.GetChild(i).GetComponent<Image>().color = Color.gray;
                    GM.item = y;
                    GM.itemnumber = i;
                }
                else
                {
                    g.GetChild(i).GetComponent<Image>().color = Color.white;
                   
                }
            }
        }
        }
    
}
