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
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < 6; i++)
        {
            inven[i] = "없음";
        }
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
    void Ray()
    {
        if (Input.GetMouseButtonDown(0))

        {

       
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit =Physics2D.Raycast(pos,Vector2.zero,0f);
          
            if (hit.collider != null)

            {
                if (!EventSystem.current.IsPointerOverGameObject()){
                        Event(hit.collider.gameObject);
                    Debug.Log(hit.collider.gameObject.name);
                }
               
            }

        }
    }
    void Event(GameObject who)
    {
        if (who.name == "normal")
        {
            r = 0;
            if (item == "없음")
            {
                On(who);
            }
        }
        else if (who.name == "Item")
        {
            r = 0;
            if (item == "없음")
            {
                Itemget(who);

            }
        }
        else if (who.name=="ItemNormal")
        {
            r = 0;
            if (item == "없음")
            {
                On(who);
                Itemget(who);

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
                item = "없음";
                itemnumber = -1;
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
        }
        else if (who.name.Substring(0, 6) == "Image_")
        {
            panel.SetActive(true);
            panel.transform.Find(who.name.Substring(6)).gameObject.SetActive(true);
        }
        else if (who.name.Substring(0, 6) == "clear,")
        {
            r = 0;
            string ser = who.name.Substring(6);
            if (null != GameObject.Find(ser))
            {
                if (item == "없음")
                {
                    clear.SetActive(true);
                }
            }
            else
            {
                Debug.Log("NO");

            }
        }
        else if (who.name.Substring(0, 7) == "normal,")
        {
            r = 0;
            string ser = who.name.Substring(7);
            if (null != GameObject.Find(ser))
            {
                if (item == "없음")
                {
                    On(who);
                }
            }
            else
            {
                Debug.Log("NO");
            }

        }
        else if (who.name.Substring(0, 7) == "normal_")
        {
            r = 0;
            if (who.name.Substring(7) == item)
            {
                inven[itemnumber] = "없음";

                if (invens.activeSelf == true)
                {
                    invens.GetComponent<Inventori>().Set();
                }
                item = "없음";
                itemnumber = -1;
                On(who);
            }
        }
       
        else if (who.name.Substring(0, 7) == "normals")
        {

            int q = int.Parse(who.name.Substring(7));
            r++;
            if (r == q)
            {
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
                }
            }
            else
            {
                Debug.Log("No");
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

    
}
