using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public Animator animator;

     public void playGame()
      {
        StartCoroutine(menuToLvSelec());
      }

     

    IEnumerator menuToLvSelec()
    {
        animator.SetBool("end", true);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

   
}

  
