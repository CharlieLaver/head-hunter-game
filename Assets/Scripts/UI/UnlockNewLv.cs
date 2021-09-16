using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UnlockNewLv : MonoBehaviour
{

    public int nextSceneLoad;

    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }
   public void UnlockNewLevel()
   {
      SceneManager.LoadScene(nextSceneLoad);

      if(nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
      {
          PlayerPrefs.SetInt("levelAt", nextSceneLoad);
      }
   }
}
