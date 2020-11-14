using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Quiz1 : MonoBehaviour{
    public Quiz_Lock one;
    public Quiz_Lock two;
    public Quiz_Lock three;
    public GameObject lock1;
    public GameObject lock2;
    public GameObject lockUI;
    // Start is called before the first frame update
    public void clear()
    {
        var singleton = Texts.Instance;
        if (one.number == 0 && two.number == 3 && three.number == 7)
        {
            lock1.SetActive(false);
            lock2.SetActive(true);
            lockUI.SetActive(false);
            singleton.TextOn("Quiz1");

        }
    } 
  
}
