using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerManager : MonoBehaviour
{
    public List<Quiz_flower> quiz;
    bool clear;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 9; i++)
        {

            quiz.Add(transform.GetChild(i).GetComponent<Quiz_flower>());
            quiz[i].name = i - 1;
        }
        
    }



    
    // Update is called once per frame
    void Update()
    {
        for (int i=0; i<=8; i++ )
        {
            if(quiz[i].a == 1)
            {
                clear = true;
                Debug.Log("clear");
            }
        }
    }

    public void Flowers(int s)
    {
        quiz[s].reverase();
    }
}
