using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //private void Awake()
    //{
    //    GhostScaredTimer = GameObject.FindGameObjectWithTag("GhostScaredTimer");
    //    GhostScaredTimer.SetActive(false);
    //}

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(1);
        //SceneManager.sceneLoaded += OnSceneLoaded;
    }
    public void LoadSecondLevel()
    {
        SceneManager.LoadScene(2);
    }
}
