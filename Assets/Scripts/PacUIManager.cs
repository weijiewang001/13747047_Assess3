using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PacUIManager : MonoBehaviour
{
    GameObject GhostScaredTimer = default;

    private void Awake()
    {
        GhostScaredTimer = GameObject.FindGameObjectWithTag("GhostScaredTimer");
        GhostScaredTimer.SetActive(false);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void LoadMenuLevel()
    {
        SceneManager.LoadScene(0);
    }
}
