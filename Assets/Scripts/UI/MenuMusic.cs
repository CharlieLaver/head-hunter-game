using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    public GameObject music;

    void Start()
    {
      if(GameObject.FindGameObjectsWithTag("Music").Length == 0)
      {
        music.SetActive(true);
      }
    }
}
