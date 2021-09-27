using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicianController : MonoBehaviour
{
    public Animator animator;
    public GameObject penfront;
    public GameObject penback;
    bool hide;
    bool trickDone;

    public Animator audienceAnimator;

    private void Awake()
    {
        StartCoroutine(Timer());
        hide = false;
        trickDone = false;
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(13f);
        animator.SetBool("Trick", true);  
        StartCoroutine(Hide());
    }

    IEnumerator Hide()
    {
        yield return new WaitForSeconds(2f);
        Time.timeScale = 0.3f;
        hide = true;
        StartCoroutine(PlayerInput());
    }

    IEnumerator PlayerInput()
    {
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(Show());
    }

    IEnumerator Show()
    {
        hide = false;
        yield return new WaitForSeconds(1.3f);
        Time.timeScale = 1f;
       
        penfront.gameObject.SetActive(true);
        penback.gameObject.SetActive(false);

        if(trickDone == true)
        {
            animator.SetBool("Bow", true);
            StaticClass.clap = true;
        }
        else
        {
            animator.SetBool("Disappointed", true);
            StaticClass.yell = true;
        }

        StartCoroutine(Reaction());
    }

    IEnumerator Reaction()
    {
        yield return new WaitForSeconds(3f);
        animator.SetBool("Idle", true);
        StartCoroutine(RotateCam());
    }

    IEnumerator RotateCam()
    {
        yield return new WaitForSeconds(4f);
        StaticClass.startCam = true;
    }


    private void Update()
    {
        if(hide == true)
        {
            if (Input.touchCount > 0)
            {
                penfront.gameObject.SetActive(false);
                penback.gameObject.SetActive(true);
                trickDone = true;
            }
        }
    }
}
