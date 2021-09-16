using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{

   public static int scoreValue = 0;
   public int nextSceneLoad;
   public GameObject lvlUp;
   public AudioSource sound;

   void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
        lvlUp.SetActive(false);
    }
  
    
    void Update()
    {
       GetComponent<TextMeshProUGUI>().text = "Score: " + scoreValue;

       Scene scene = SceneManager.GetActiveScene();

       if(scene.name == "Scene1")
       {
          Lvl2Unlock();
       }

       if(scene.name == "Scene2")
       {
          Lvl3Unlock();
       }

       if(scene.name == "Scene3")
       {
          Lvl4Unlock();
       }

       if(scene.name == "Scene4")
       {
          Lvl5Unlock();
       }

       if(scene.name == "Scene5")
       {
          Lvl6Unlock();
       }

       
    
    }

    public void Lvl2Unlock()
    {
      if(scoreValue == 100)
      {
        if(nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
      {
         sound.Play();
         PlayerPrefs.SetInt("levelAt", nextSceneLoad);
         lvlUp.SetActive(true);
         Destroy(lvlUp, 3f);
      }  
      }
    }

    public void Lvl3Unlock()
    {
      if(scoreValue == 200)
      {
        if(nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
      {
          sound.Play();
          lvlUp.SetActive(true);
          PlayerPrefs.SetInt("levelAt", nextSceneLoad);
          Destroy(lvlUp, 3f);
      }
      }
    }

    public void Lvl4Unlock()
    {
      if(scoreValue == 400)
      {
        if(nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
      {
          sound.Play();
          lvlUp.SetActive(true);
          PlayerPrefs.SetInt("levelAt", nextSceneLoad);
          Destroy(lvlUp, 3f);
      }
      }
    }

    public void Lvl5Unlock()
    {
      if(scoreValue == 800)
      {
        if(nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
      {
          sound.Play();
          lvlUp.SetActive(true);
          PlayerPrefs.SetInt("levelAt", nextSceneLoad);
          Destroy(lvlUp, 3f);
      }
      }
    }

    public void Lvl6Unlock()
    {
      if(scoreValue == 1600)
      {
        if(nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
      {
          sound.Play();
          lvlUp.SetActive(true);
          PlayerPrefs.SetInt("levelAt", nextSceneLoad);
          Destroy(lvlUp, 3f);
      }
      }
    }






     
    
}
