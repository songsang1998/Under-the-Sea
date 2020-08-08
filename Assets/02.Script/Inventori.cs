using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventori : MonoBehaviour
{
    // Start is called before the first frame update
    public Sensing Manager;
    void Start()
    {
       
    }

    // Update is called once per frame
   
    public void Set()
    {
        for (int i = 0; i < 6; i++)
        {
            if (transform.GetChild(i).transform.childCount!= 0)
            {
               
                Destroy(transform.GetChild(i).transform.GetChild(0).gameObject);
                transform.GetChild(i).GetComponent<Image>().color = Color.white;
            }

            if (Manager.inven[i] != "없음")
            {
                
                GameObject p=Resources.Load(Manager.inven[i]) as GameObject;
                GameObject item = Instantiate(p,transform.GetChild(i)) as GameObject;
                item.transform.parent = transform.GetChild(i);
            }
        }
    }


}
