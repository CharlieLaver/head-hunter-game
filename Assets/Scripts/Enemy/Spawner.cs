using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawner : MonoBehaviour
{
 
public GameObject spawnObject;
public int howManySpawners = 1;
public GameObject[] spawners;



private DateTime lastTime;
public int delayInSeconds = 10;

private void Start()
   {
       spawners = new GameObject[howManySpawners];

       for(int i = 0; i < spawners.Length; i++)
       {
          spawners[i] = transform.GetChild(i).gameObject; 
       }

   }




void Update()
{
        
    if(AllowSpawn())
    {
        SpawnObjectAtRandom();
    }
    
            
}

void SpawnObjectAtRandom()
{
    int spawnerID = UnityEngine.Random.Range(0, spawners.Length);
      Instantiate(spawnObject, spawners[spawnerID].transform.position, spawners[spawnerID].transform.rotation);
}

bool AllowSpawn()
    {
        DateTime time = DateTime.Now;
        TimeSpan ts = time - lastTime; 
        if (ts.TotalSeconds > delayInSeconds)
        {
            lastTime = time;
            return true;
        } 
        return false;
    }
 
}


