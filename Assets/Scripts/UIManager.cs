using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadSecondLevel()
    {
        SceneManager.LoadScene(2);
    }
}
