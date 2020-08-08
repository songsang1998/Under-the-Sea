using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    int Camerapoint;
    public GameObject Up;
    public GameObject Down;
    // Start is called before the first frame update
    void Start()
    {
        Camerapoint = 0; 
    }

    private void Update()
    {
        if (Camerapoint == 0)
        {
            Down.SetActive(false);

        }
        else if (Camerapoint == 2)
        {
            Up.SetActive(false);

        }
        else
        {
            Down.SetActive(true);
            Up.SetActive(true);
        }
    }
    // Update is called once per frame
    public void CameraUp()
    {
        transform.position += new Vector3(0,10.5f,0);
        Camerapoint++;
    }

    public void CameraDown()
    {
        transform.position -= new Vector3(0, 10.5f, 0);
        Camerapoint--;
    }
}
