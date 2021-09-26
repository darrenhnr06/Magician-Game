using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicianController : MonoBehaviour
{
    public Animator animator;

    private void Awake()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(12f);
        animator.SetBool("Trick", true);
    }
}
