using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz_artnumber : MonoBehaviour
{
    public int number;
    public List<Sprite> image;
    bool who;
    ButtonManger k;
    public int widths;
    // Start is called before the first frame update
    void Start()
    {
        //who = false;
        GetComponent<Image>().sprite = image[number];
        k = transform.parent.GetComponent<ButtonManger>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Image>().sprite = image[number];
    }
    public void Click()
    {
        if (/*who == false &&*/ k.button == null)
        {
            k.button = this;
           // who = true;
            k.buttonup(widths);
        }
        else if(/*who==true  &&*/ k.button==this)
        {
            k.buttondown(widths);
            //who = false;
            k.button = null;
        }
    }

    public void buring()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }
    public void Exits()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
    public void aChange()
    {
        k.buttondown(k.button.widths);
        int temp = k.button.number;
        
        k.button.number = number;
        number = temp;
       // k.button.who = false;
        k.button = null;
        k.Clear();
        
    }
}
