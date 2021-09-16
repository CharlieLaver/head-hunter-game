using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSequence : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
       StartCoroutine(ToMainMenu());
    }

    IEnumerator ToMainMenu()
    {
        yield return new WaitForSeconds(1.5f);
        animator.SetBool("end", true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
}
