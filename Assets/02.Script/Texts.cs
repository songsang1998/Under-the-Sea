using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Texts : MonoBehaviour
{
    public text TextDB;
    public GameObject Text1;
    public Text player;
    public Text script;
    private static Texts instance;
    string otext;
    string stext;
 

  
    int i;
    public static Texts Instance

    {

        get

        {

            if (instance == null)

            {

                var obj = FindObjectOfType<Texts>();

                if (obj != null)

                {

                    instance = obj;

                }

                else

                {

                    var newSingleton = new GameObject("TextManager").AddComponent<Texts>();

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
    private void Awake()

    {

        var objs = FindObjectsOfType<Texts>();


        if (objs.Length != 1)

        {

            Destroy(gameObject);

            return;

        }
        
        TextDB = Resources.Load("DB/text") as text;
        Text1 = GameObject.Find("Canvas").transform.Find("speaking").gameObject;

        player = Text1.transform.Find("name").GetComponent<Text>();
        script = Text1.transform.Find("speaking").GetComponent<Text>();
        DontDestroyOnLoad(gameObject);
    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Text1 = GameObject.Find("Canvas").transform.Find("speaking").gameObject;

        player = Text1.transform.Find("name").GetComponent<Text>();
        script = Text1.transform.Find("speaking").GetComponent<Text>();

    }
    public void TextOn(string objectname)
    {
        
        Text1.gameObject.SetActive(true);
        for (i = 0; i < TextDB.dataArray.Length; i++)
        {

            if (TextDB.dataArray[i].Objects==objectname) {

                textData read = TextDB.dataArray[i];
                string s = read.Player;
                player.text = s;
                
                otext = read.Text;
                StartCoroutine("TypingAction");


                break;
            }

            //}
        }
    }
    public void TextNo(string objectname)
    {

        Text1.gameObject.SetActive(true);
        for (i = 0; i < TextDB.dataArray.Length; i++)
        {

            if (TextDB.dataArray[i].Objects == objectname)
            {

                textData read = TextDB.dataArray[i];
                string s = read.Player;
                player.text = s;

                otext = read.No;
                StartCoroutine("TypingAction");


                break;
            }

            //}
        }
    }
    public void TextItemNo(string objectname)
    {

        Text1.gameObject.SetActive(true);
        for (i = 0; i < TextDB.dataArray.Length; i++)
        {

            if (TextDB.dataArray[i].Objects == objectname)
            {

                textData read = TextDB.dataArray[i];
                string s = read.Player;
                player.text = s;

                otext = read.Itemno;
                StartCoroutine("TypingAction");


                break;
            }

            //}
        }
    }
    public void TextUp()
    {
        if (TextDB.dataArray[i].Next == "0")
        {
            Text1.gameObject.SetActive(false);
            StopCoroutine("TypingAction");
            Sensing.bool_texts = false;
        }
    }
 

    IEnumerator TypingAction()
    {
        for (int i = 0; i <= otext.Length; i++)
        {

            stext += otext.Substring(0, i);
            script.text = stext;
            stext = "";
            yield return new WaitForSeconds(0.045f);
        }

    }

}