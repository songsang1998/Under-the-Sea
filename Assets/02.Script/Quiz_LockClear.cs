using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz_LockClear : MonoBehaviour
{
    // Start is called before the first frame update
    public Quiz_Lock one;
    public Quiz_Lock two;
    public Quiz_Lock three;

    // Update is called once per frame
    void Update()
    {
        if(one.number==5&& two.number == 0 && three.number == 6)
        {
            Debug.Log("clear");
        }
    }
}
