using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenemove : MonoBehaviour
{
    // Start is called before the first frame update
    public void Scenemoves()
    {
        Destroy(Texts1.Instance.gameObject);
        SceneManager.LoadScene("Title_Scene");
        
    }
}
