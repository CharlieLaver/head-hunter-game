using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapLoad : MonoBehaviour
{
    public Animator animator;

    public void Lv1()
    {
       StartCoroutine(lvl1());
    }

    public void Lv2()
    {
        StartCoroutine(lvl2());
    }

    public void Lv3()
    {
        StartCoroutine(lvl3());
    }

    public void Lv4()
    {
        StartCoroutine(lvl4());
    }

    public void Lv5()
    {
        StartCoroutine(lvl5());
    }

    public void Lv6()
    {
        StartCoroutine(lvl6());
    }

    public void Back()
      {
        StartCoroutine(back());
      }

    public void LoadCurrentScene()
    {
      StartCoroutine(restart());
    }

    IEnumerator back()
    {
        animator.SetBool("end", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("MapMenu");
        ScoreScript.scoreValue = 0; 
    }

    IEnumerator restart()
    {
        animator.SetBool("end", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex); 
        ScoreScript.scoreValue = 0;
    }

    IEnumerator lvl1()
    {
        animator.SetBool("end", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Scene1");
    }

    IEnumerator lvl2()
    {
        animator.SetBool("end", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Scene2");
    }

    IEnumerator lvl3()
    {
        animator.SetBool("end", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Scene3");
    }

    IEnumerator lvl4()
    {
        animator.SetBool("end", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Scene4");
    }

    IEnumerator lvl5()
    {
        animator.SetBool("end", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Scene5");
    }

    IEnumerator lvl6()
    {
        animator.SetBool("end", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Scene6");
    }
}
