using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz_flower : MonoBehaviour
{
    public int a;
    public int b;
    public FlowerManager s;
    // Start is called before the first frame update
    void Awake()
    {
        a = 0;

        Setting();

    }

    // Update is called once per frame
    public void Sync(int i)
    {
        b = i;
    }
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
        if (b + 3 <= 8)
        {
            if (b % 3 != 0)
            {
                s.Flowers(b + 3-1);
            }

            if (b % 3 != 2)
            {
                s.Flowers(b + 3 + 1);
            }
        }
        if(b-3>=0)
        {
            if (b % 3 != 0)
            {
                s.Flowers(b - 3 - 1);
            }
            if (b % 3 != 2)
            {
                s.Flowers(b - 3 + 1);
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
