using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class Sensing : MonoBehaviour
{
    public string item = "없음";
    public string[] inven = new string[6];
    public GameObject invens;
    public GameObject panel;
    public GameObject clear;
    public GameObject die;
    public int itemnumber = -1;
    int r = 0;
    public static bool bool_story;
    public static bool bool_puzzle;
    public static bool bool_texts;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < 6; i++)
        {
            inven[i] = "없음";
        }
        TextUpstory();
    }
  
    // Update is called once per frame
    void Update()
    {
        
       
            Ray();
        
       

    }
    public void Seton()
    {
        if (invens.activeSelf == true)
        {
            invens.SetActive(false);
        }
        else
        {
            invens.SetActive(true);
            invens.GetComponent<Inventori>().Set();
        }
    }
    public void Imageoff()
    {
        bool_puzzle = false;
    }
    void Ray()
    {
       
       
       if (Input.GetMouseButtonDown(0))

       {
                Debug.Log(bool_story);
                Debug.Log(bool_puzzle);
                Debug.Log(bool_texts);
            if (bool_story == false && bool_puzzle == false && bool_texts == false)
            {
                Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

                if (hit.collider != null)

                {
                    if (!EventSystem.current.IsPointerOverGameObject())
                    {
                        Event(hit.collider.gameObject);
                        Debug.Log(hit.collider.gameObject.name);
                    }

                }


            }

        }
    }
    void Event(GameObject who)
    {
        var sm = SoundManager.Instance;
        var singleton = Texts.Instance;
        if (who.name == "normal")
        {
            r = 0;
            if (item == "없음")
            {
                On(who);
                singleton.TextOn(who.transform.parent.name);
                bool_texts = true;
                sm.PlaySFX("Click");
            }
           
           
        }
        else if (who.name == "Item")
        {
            r = 0;
            if (item == "없음")
            {
                Itemget(who);
                singleton.TextOn(who.transform.parent.name);
                bool_texts = true;
                sm.PlaySFX("Click");

            }
            
        }
        else if (who.name=="ItemNormal")
        {
            r = 0;
            if (item == "없음")
            {
                On(who);
                Itemget(who);
                singleton.TextOn(who.transform.parent.name);
                bool_texts = true;
                sm.PlaySFX("Click");
            }
           
        }
        else if (who.name.Substring(0,4) == "die_")
        {
            r = 0;
            die.SetActive(true);
        }
        
        else if (who.name.Substring(0, 5) == "Item_")
        {
            r = 0;
            if (who.name.Substring(5) == item)
            {
                inven[itemnumber] = "없음";

                if (invens.activeSelf == true)
                {
                    invens.GetComponent<Inventori>().Set();
                }
               
                singleton.TextOn(who.transform.parent.name);
                bool_texts = true;
                item = "없음";
                itemnumber = -1;
                sm.PlaySFX("Click");
                for (int i = 0; i < 6; i++)
                {
                    if (inven[i] == "없음")
                    {
                       
                        inven[i] = who.transform.parent.name.Replace("Object_", "");
                        if (invens.activeSelf == true)
                        {
                            invens.GetComponent<Inventori>().Set();
                        }

                        break;

                    }
                   
                }
            }
            else if(item=="없음")
            {
                sm.PlaySFX("Boong");
                singleton.TextItemNo(who.transform.parent.name);
            }
        }
        else if (who.name.Substring(0, 5) == "Text_")
        {
            singleton.TextOn(who.transform.parent.name);
            bool_texts = true;
        }
        else if (who.name.Substring(0, 6) == "Image_")
        {
            bool_puzzle = true;
            panel.SetActive(true);
            panel.transform.Find(who.name.Substring(6)).gameObject.SetActive(true);
            sm.PlaySFX("Boong");
        }
        else if (who.name.Substring(0, 6) == "clear,")
        {
            r = 0;
            string ser = who.name.Substring(6);
            if (null != GameObject.Find(ser))
            {

                if (item == "없음")
                {
                    sm.PlaySFX("Click");
                    clear.SetActive(true);
                }
               
            }
            else
            {
                Debug.Log("NO");
                singleton.TextItemNo(who.transform.parent.name);
                sm.PlaySFX("Boong");
            }
        }
        else if (who.name.Substring(0, 6) == "clear.")
        {
            clear.SetActive(true);
        }
       
        else if (who.name.Substring(0, 7) == "normal,")
        {
            r = 0;
            string ser = who.name.Substring(7);
            if (null != GameObject.Find(ser))
            {
                if (item == "없음")
                {
                    sm.PlaySFX("Click");
                    On(who);
                    singleton.TextOn(who.transform.parent.name);

                    bool_texts = true;
                }
            }
            else
            {
                singleton.TextNo(who.transform.parent.name);
                Debug.Log("NO");
                sm.PlaySFX("Boong");
            }

        }
        else if (who.name.Substring(0, 7) == "normal_")
        {
            r = 0;
            if (who.name.Substring(7) == item)
            {
                inven[itemnumber] = "없음";
                singleton.TextOn(who.transform.parent.name);
                bool_texts = true;
                if (invens.activeSelf == true)
                {
                    invens.GetComponent<Inventori>().Set();
                }
                item = "없음";
                itemnumber = -1;
                On(who);
                sm.PlaySFX("Click");
            }
            else if (item == "없음")
            {
                singleton.TextItemNo(who.transform.parent.name);
                sm.PlaySFX("Boong");
            }
        }
       
        else if (who.name.Substring(0, 7) == "normals")
        {

            int q = int.Parse(who.name.Substring(7));
            r++;
            if (r == q)
            {
                 sm.PlaySFX("Click");
                On(who);
            }
        }
        else if (who.name.Substring(0,7) == "normal+")
        {
            r = 0;
            string qser = who.name.Replace("normal+", "");
         
            int serach= qser.IndexOf("/");
            
            string ser = qser.Substring(0,serach);
          
            if (null != GameObject.Find(ser))
            {
                
                if (qser.Substring(serach+1) == item)
                {
                    inven[itemnumber] = "없음";

                    if (invens.activeSelf == true)
                    {
                        invens.GetComponent<Inventori>().Set();
                    }
                    item = "없음";
                    itemnumber = -1;
                    On(who);
                    singleton.TextOn(who.transform.parent.name);
                    bool_texts = true;
                }
                else if (item == "없음")
                {
                    singleton.TextItemNo(who.transform.parent.name);
                }
            }
            else
            {
                singleton.TextNo(who.transform.parent.name);
                Debug.Log("No");
                sm.PlaySFX("Boong");
            }
        }

      

    }

    void On(GameObject whos)
    {

        whos.transform.parent.GetChild(1).gameObject.SetActive(true);
        if (whos.activeSelf == true)
        {
            whos.SetActive(false);
          
        }
    }

    void Itemget(GameObject who)
    {
        if (who.activeSelf == true)
        {
            who.SetActive(false);
        }
        for (int i = 0; i < 6; i++)
        {
            if (inven[i] == "없음")
            {
                inven[i] = who.transform.parent.name.Replace("Object_", "");
                if (invens.activeSelf == true)
                {
                    invens.GetComponent<Inventori>().Set();
                }
                break;
            }
        }
    }

    public void TextUps()
    {
        var singleton = Texts.Instance;
        singleton.TextUp();

    }

    public void TextUpstory()
    {
        var singleton = Texts1.Instance;
        singleton.Texts();
        
    }
}
