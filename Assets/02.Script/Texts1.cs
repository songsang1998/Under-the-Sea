using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Texts1 : MonoBehaviour
{
    public story stroyDB;
    public int i;
    private static Texts1 instance;
    // Start is called before the first frame update
    public static Texts1 Instance

    {

        get

        {

            if (instance == null)

            {

                var obj = FindObjectOfType<Texts1>();

                if (obj != null)

                {

                    instance = obj;
                    
                }

                else

                {

                    var newSingleton = new GameObject("TextManager").AddComponent<Texts1>();

                    instance = newSingleton;

                }

            }

            return instance;

        }

        private set

        {

            instance = value;

        }


    }
    GameObject textGameobject;
    Text text;
    GameObject eventSystem;
    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        i = 0;
        stroyDB = Resources.Load("DB/story") as story;
        text = GameObject.Find("Canvas").transform.Find("Story").transform.Find("Text").GetComponent<Text>();
        textGameobject = GameObject.Find("Canvas").transform.Find("Story").gameObject;
        eventSystem = GameObject.Find("EventSystem");
        Sensing.bool_story = true;
    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        text = GameObject.Find("Canvas").transform.Find("Story").transform.Find("Text").GetComponent<Text>();
        textGameobject = GameObject.Find("Canvas").transform.Find("Story").gameObject;
       
    }
        // Update is called once per frame
    public void Texts()
    {
        if (i == 8)
        {
            SceneManager.LoadScene(2);
            eventSystem.SetActive(false);
        }
        text.text = stroyDB.dataArray[i].Texts;
        
        if (i != 0 && stroyDB.dataArray[i - 1].Explanation == 1)
        {
          
            textGameobject.SetActive(false);
           
            Sensing.bool_story = false;

        }
        i++;
        
    }
}
