using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PacmanMovement : MonoBehaviour
{
    public Animator animatorController;
    private void Start()
    {
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            animatorController.SetTrigger("PacmanLeft");
        }
    }

}
