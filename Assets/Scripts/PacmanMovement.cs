using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PacmanMovement : MonoBehaviour
{
    private GameObject pacman = default;
    private Animator pacmanAnimator = default;
    private float timer;
    //public Animator animatorController;
    public AudioSource noEatingMoveAudio;
    float timeElapsed;
    const float lerpPeriodA = 4f;
    const float lerpPeriodB = 2.5f;
    


    private void Start()
    {
        pacman = GameObject.FindWithTag("Pacman"); 
        pacman.transform.position = new Vector3(-12.5f, 13.5f, 0f);
        timeElapsed = 0;

    }

    private void Update()
    {
        //No eating Player
        timer += Time.deltaTime;
        if(timer - 0.5 > 0)
        {
            noEatingMoveAudio.Play();
            timer = 0;
        }


        //The first path
        if (timeElapsed < lerpPeriodA && timeElapsed >= 0  )
        {
            pacman.transform.position = Vector3.Lerp(new Vector3(-12.5f, 13.5f, 0), new Vector3(-1.5f, 13.5f, 0), timeElapsed / lerpPeriodA);
            timeElapsed += Time.deltaTime;
        }

        //The second path
        if (timeElapsed < (lerpPeriodA + lerpPeriodB) && timeElapsed >= lerpPeriodA)
        {
            pacman.transform.position = Vector3.Lerp(new Vector3(-1.5f, 13.5f, 0), new Vector3(-1.5f, 9.5f, 0), (timeElapsed - lerpPeriodA) / lerpPeriodB);
            timeElapsed += Time.deltaTime;
        }

        //The third path
        if (timeElapsed >= (lerpPeriodA + lerpPeriodB) && timeElapsed < (lerpPeriodA * 2 + lerpPeriodB))
        {
            pacman.transform.position = Vector3.Lerp(new Vector3(-1.5f, 9.5f, 0), new Vector3(-12.5f, 9.5f, 0), (timeElapsed - lerpPeriodA - lerpPeriodB) / lerpPeriodA);
            timeElapsed += Time.deltaTime;
        }

        //The forth path
        if (timeElapsed >= (lerpPeriodA * 2 + lerpPeriodB) && timeElapsed < 2 * (lerpPeriodA + lerpPeriodB))
        {
            pacman.transform.position = Vector3.Lerp(new Vector3(-12.5f, 9.5f, 0), new Vector3(-12.5f, 13.5f, 0), (timeElapsed - lerpPeriodA * 2 - lerpPeriodB) / lerpPeriodB);
            timeElapsed += Time.deltaTime;
        }
        
        //Reset timeElapsed
        if (timeElapsed >= 2 * (lerpPeriodA + lerpPeriodB))
        {
            timeElapsed = 0;
        }

        
    }
   

}
