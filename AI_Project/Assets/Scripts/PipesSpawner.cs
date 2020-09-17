using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    public GameObject pipe;

    public float spawnRate = 2.5f;
    public float timeToSpawn = 0f;

    
    void Start()
    {
        timeToSpawn = spawnRate;
    }


    void Update()
    {
        if(timeToSpawn < 0)
        {
            Instantiate(pipe, pipe.transform.position, Quaternion.identity);
            timeToSpawn = spawnRate;
        }

        else
        {
            timeToSpawn -= Time.deltaTime;
        }
        
    }
}
