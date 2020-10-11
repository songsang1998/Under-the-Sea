using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerManager : MonoBehaviour
{
    public List<Quiz_flower> quiz;
    bool clear;
    bool k;
    public GameObject one;
    public GameObject two;
    // Start is called before the first frame update
    void Awake()
    {
        for (int i = 1; i <= 9; i++)
        {

            quiz.Add(transform.GetChild(i).GetComponent<Quiz_flower>());
            //quiz[i].Sync(i);
        }


        
    }

    

    
    // Update is called once per frame
    void check()
    {
        k = true;
        for (int i=0; i<=8; i++ )
        {
            
            Debug.Log(i+""+quiz[i].a);
            if (quiz[i].a == 0)
            {
       
                if (i!= 4)
                {
                    k = false;
                }

            }
            else if(quiz[i].a==1)
            {
                if (i == 4)
                {
                    k = false;
                }
            }
        }
        if (k)
        {
            clear = true;
        }
        if (clear == true)
        {
            clear = false;
            one.SetActive(false);
            two.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    public void Flowers(int s)
    {
        quiz[s].reverase();
        check();
    }
}
