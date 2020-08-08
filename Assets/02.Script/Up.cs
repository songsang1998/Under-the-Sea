using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Up : MonoBehaviour
{
    // Start is called before the first frame update
    int a;
    Text R;
    Quiz1 quiz;
    void Start()
    {
        quiz=GameObject.Find("QuizManager").GetComponent<Quiz1>();
        a = 0;
        R = GetComponent<Text>();
    }

    // Update is called once per frame
    
    public void Ups()
    {
        if (a != 9)
        {
            a++; 
        }
        else
        {
            a = 0;
        }

        
        R.text = a.ToString();
        quiz.clear();
    }
    public void Downs()
    {
        if (a != 0)
        {
            a--;
        }
        else
        {
            a = 9;
        }
       
        R.text = a.ToString();
        quiz.clear();
    }
}
