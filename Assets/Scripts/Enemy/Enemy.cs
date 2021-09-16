using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject deathEffect;
    GameObject soundObj;
    AudioSource sound;

    void Start()
    {
      soundObj = GameObject.Find("HeadDeath");
      sound = soundObj.GetComponent<AudioSource>();
    }

    public void TakeDamage (int damage)
    {
       health -= damage;
      
       if (health <= 0)
        {

          Die();
       
        }
 
    }

  void Die ()
  {
    sound.Play();
    Instantiate(deathEffect, transform.position, Quaternion.identity);
    Destroy(gameObject);

    ScoreScript.scoreValue += 10;    
   
  }

} 
  
