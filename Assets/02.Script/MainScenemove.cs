﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScenemove : MonoBehaviour
{
    // Start is called before the first frame update
    public void Scenemove()
    {
        SceneManager.LoadScene(2);
    }
    public void QuitGame()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying=false; 
    #else
        Application.Quit();
    #endif
    }

    
}
