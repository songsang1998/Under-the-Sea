using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerManager : MonoBehaviour
{
    public List<Quiz_flower> quiz;
    bool clear;
    bool k;
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
    void Update()
    {

        for (int i=0; i<=8; i++ )
        {
            k = true;
            if(quiz[i].a == 1)
            {


            }
            else
            {
                k = false;
            }
        }
        if (k)
        {
            clear = true;
        }
    }

    public void Flowers(int s)
    {
        quiz[s].reverase();
    }
}
