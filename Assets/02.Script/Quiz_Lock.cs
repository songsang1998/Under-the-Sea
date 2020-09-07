using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Quiz_Lock : MonoBehaviour
{
    // Start is called before the first frame update
    public int number;
    public List<Sprite> so;
    Image main;
    void Start()
    {
        main = GetComponent<Image>();
         number=0;
        Setting();
    }

    // Update is called once per frame
    public void Up()
    {
        if (number == 9)
        {
            number =0;
        }
        else{
            number++;
        }
        Setting();
    }
    public void Down()
    {
        
        if (number == 0)
        {
            number = 9;
        }
        else
        {
            number--;
        }
        Setting();
    }
    void Setting()
    {


        main.sprite = so[number];
        
    }
}
