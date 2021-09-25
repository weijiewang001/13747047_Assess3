using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PacmanMovement : MonoBehaviour
{
    //private bool switchedOn = false;
    private GameObject pacman = default;
    private Animator pacmanAnimator = default;
    //public Animator animatorController;
    public AudioSource moveAudio;
    float speed = 2.5f;
    float timeElapsed;
    const float lerpDurationA = 4.8f;
    const float lerpDurationB = 2f;


    private void Start()
    {
        pacman = GameObject.FindWithTag("Pacman"); 
        pacman.transform.position = new Vector3(-12.5f, 13.5f, 0f);
        pacmanAnimator = pacman.GetComponent<Animator>();
        //pacmanAnimator.SetTrigger("Pacman_TurnRight");
        timeElapsed = 0;

    }

    private void Update()
    {
        if (timeElapsed >= lerpDurationA && timeElapsed < (lerpDurationA + lerpDurationB))
        {
            pacman.transform.position = Vector3.Lerp(new Vector3(-1.5f, 13.5f, 0), new Vector3(-1.5f, 9.5f, 0), (timeElapsed - lerpDurationA) / lerpDurationB);
            timeElapsed += Time.deltaTime;
        }
        if (timeElapsed >= (lerpDurationA + lerpDurationB) && timeElapsed < (lerpDurationA * 2 + lerpDurationB))
        {
            pacman.transform.position = Vector3.Lerp(new Vector3(-1.5f, 9.5f, 0), new Vector3(-12.5f, 9.5f, 0), (timeElapsed - lerpDurationA - lerpDurationB) / lerpDurationA);
            timeElapsed += Time.deltaTime;
        }
        if (timeElapsed >= (lerpDurationA * 2 + lerpDurationB) && timeElapsed < 2 * (lerpDurationA + lerpDurationB))
        {
            pacman.transform.position = Vector3.Lerp(new Vector3(-12.5f, 9.5f, 0), new Vector3(-12.5f, 13.5f, 0), (timeElapsed - lerpDurationA * 2 - lerpDurationB) / lerpDurationB);
            timeElapsed += Time.deltaTime;
        }
        if (timeElapsed >= 0 && timeElapsed < lerpDurationA)
        {
            pacman.transform.position = Vector3.Lerp(new Vector3(-12.5f, 13.5f, 0), new Vector3(-1.5f, 13.5f, 0), timeElapsed / lerpDurationA);
            timeElapsed += Time.deltaTime;
        }
        if (timeElapsed >= 2 * (lerpDurationA + lerpDurationB))
        {
            timeElapsed = 0;
        }

        //if(Input.GetKeyDown(KeyCode.A))
        //{
        //    animatorController.SetTrigger("PacmanLeft");
        //    moveAudio.Play();
        //}
    }

}
