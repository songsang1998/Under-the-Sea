using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Quiz1 : MonoBehaviour{
    public Text one;
    public Text two;
    public Text three;
    public GameObject lock1;
    public GameObject lock2;
    public GameObject lockUI;
    // Start is called before the first frame update
    public void clear()
    {
        if(one.text == "1" && two.text == "4" && three.text == "8")
        {
            lock1.SetActive(false);
            lock2.SetActive(true);
            lockUI.SetActive(false);
        }
    } 
  
}
