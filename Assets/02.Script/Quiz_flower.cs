using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz_flower : MonoBehaviour
{
    public int a;
    public int name;
    // Start is called before the first frame update
    void Start()
    {
        a = 0;
        Setting();
    }

    // Update is called once per frame
    
    void Setting()
    {
        if (a == 0)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
        }
       
    }

    public void flower()
    {
        if(name%3==0)
        {
            if (name - 3 > 0)
            {

            }
        }
    }
    public void reverase()
    {
        if (a == 0)
        {
            a = 1;
        }
        else
        {
            a = 0;
        }
        Setting();
    }

}
