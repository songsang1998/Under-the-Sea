using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        
        Camera camera = GetComponent<Camera>();
        Rect rect = camera.rect;
        float height = ((float)Screen.width / Screen.height) / ((float)16 / 9);
       
        float width = 1f / height;

        if (height < 1)
        {
            rect.width = height;
            rect.x = (1f - height) / 2f;
        }
        else
        {
            rect.width = width;
            rect.x=(1f-width)/2f;
        }
        camera.rect = rect;
    }

    // Update is called once per frame
        
}
