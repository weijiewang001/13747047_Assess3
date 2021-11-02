using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
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
    public void LoadMenuLevel()
    {
        SceneManager.LoadScene(0);
    }
}
