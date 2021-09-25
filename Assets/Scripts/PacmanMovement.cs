using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PacmanMovement : MonoBehaviour
{
    private bool switchedOn = false;
    private GameObject pacman = default;
    private Animator pacmanAnimator = default;
    public Animator animatorController;
    public AudioSource moveAudio;
    float speed = 2.5f;

    private void Start()
    {
        pacman = GameObject.FindWithTag("Pacman"); 
        pacman.transform.position = new Vector3(-12.5f, 13.5f, 0f);
        //pacmanAnimator = pacman.GetComponent<Animator>();
        pacmanAnimator.SetTrigger("Pacman_TurnRight");
    }

    private void Update()
    {
        if (pacman.transform.position.x >= -12.5f && pacman.transform.position.x < -1.5f && pacman.transform.position.y == 13.5f)
        {
            pacman.transform.position += (Vector3.right * speed * Time.deltaTime);
        }
        if (pacman.transform.position.x == -1.5f && pacman.transform.position.y <= 13.5f && pacman.transform.position.y > 9.5)
        {
            pacman.transform.position += (Vector3.down * speed * Time.deltaTime);
        }
        if (pacman.transform.position.x != -1.5f && pacman.transform.position.y == 13.5f)
        {
            pacman.transform.position += (Vector3.right * speed * Time.deltaTime);
        }
        else if (pacman.transform.position.x == -1.5f && pacman.transform.position.y != 9.5)
        {
            pacman.transform.position += (Vector3.down * speed * Time.deltaTime);
        }
        else if (pacman.transform.position.x != -12.5f && pacman.transform.position.y == 9.5)
        {
            pacman.transform.position += (Vector3.left * speed * Time.deltaTime);
        }
        else
        {
            pacman.transform.position += (Vector3.up * speed * Time.deltaTime);
        }

        //if(Input.GetKeyDown(KeyCode.A))
        //{
        //    animatorController.SetTrigger("PacmanLeft");
        //    moveAudio.Play();
        //}
    }

}
