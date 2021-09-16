using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStop : MonoBehaviour
{
   GameObject music;

    void Start()
    {
      music = GameObject.FindGameObjectWithTag("Music");
      music.GetComponent<MusicClass>().StopMusic();
      Destroy(music);
    }

   
}
