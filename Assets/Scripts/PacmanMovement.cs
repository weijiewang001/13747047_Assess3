using UnityEngine;

public class PacmanMovement : MonoBehaviour
{
    private GameObject pacman = default;
    //private Animator pacmanAnimator = default;
    private float timer;
    //public Animator animatorController;
    public AudioSource noEatingMoveAudio;
    //float timeElapse;
    //float Period1 = 4f;
    //float Period2 = 2.5f;
    


    private void Start()
    {
        pacman = GameObject.FindWithTag("Pacman"); 
        pacman.transform.position = new Vector3(-12.5f, 13.5f, 0f);
        //timeElapse = 0;

    }

    private void Update()
    {
        //No eating Player
        timer += Time.deltaTime;

        //play music
        //if(timer - 0.5 > 0)
        //{
        //    noEatingMoveAudio.Play();
        //    timer = 0;
        //}




        ////The first path
        //if (timeElapse < Period1 && timeElapse >= 0  )
        //{
        //    pacman.transform.position = Vector3.Lerp(new Vector3(-12.5f, 13.5f, 0), new Vector3(-1.5f, 13.5f, 0), timeElapse / Period1);
        //    timeElapse += Time.deltaTime;
        //}

        ////The second path
        //if (timeElapse < (Period1 + Period2) && timeElapse >= Period1)
        //{
        //    pacman.transform.position = Vector3.Lerp(new Vector3(-1.5f, 13.5f, 0), new Vector3(-1.5f, 9.5f, 0), (timeElapse - Period1) / Period2);
        //    timeElapse += Time.deltaTime;
        //}

        ////The third path
        //if (timeElapse >= (Period1 + Period2) && timeElapse < (Period1 * 2 + Period2))
        //{
        //    pacman.transform.position = Vector3.Lerp(new Vector3(-1.5f, 9.5f, 0), new Vector3(-12.5f, 9.5f, 0), (timeElapse - Period1 - Period2) / Period1);
        //    timeElapse += Time.deltaTime;
        //}

        ////The forth path
        //if (timeElapse >= (Period1 * 2 + Period2) && timeElapse < 2 * (Period1 + Period2))
        //{
        //    pacman.transform.position = Vector3.Lerp(new Vector3(-12.5f, 9.5f, 0), new Vector3(-12.5f, 13.5f, 0), (timeElapse - Period1 * 2 - Period2) / Period2);
        //    timeElapse += Time.deltaTime;
        //}
        
        ////Reset timeElapsed
        //if (timeElapse >= 2 * (Period1 + Period2))
        //{
        //    timeElapse = 0;
        //}

        
    }
   

}
