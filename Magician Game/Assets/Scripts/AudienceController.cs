using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudienceController : MonoBehaviour
{
    private Animator animator;
    private GameObject happyEmoji;
    private GameObject angryEmoji;
    private GameObject gameObjectCopy;
    bool popup;

    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        happyEmoji = gameObject.transform.Find("Happy").gameObject;
        angryEmoji = gameObject.transform.Find("Angry").gameObject;
        //popup = false;

    }

 
    private void Update()
    {
        if(StaticClass.clap == true)
        {
            animator.Play("Clap");
            gameObjectCopy = happyEmoji;
            gameObjectCopy.gameObject.SetActive(true);
            //popup = true;
        }

        if(StaticClass.yell == true)
        {
            animator.Play("Yell");
            gameObjectCopy = angryEmoji;
            gameObjectCopy.gameObject.SetActive(true);
            //popup = true;
        }
    }
}
