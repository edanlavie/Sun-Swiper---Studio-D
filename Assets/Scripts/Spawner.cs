﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] meteorPatterns;

    private float timeBetweenSpawn;
    public float startTimeBetweenSpawn;
    public float decreaseTime;
    public float minTime = 0.65f; 

    private void Update()
    {
        if (timeBetweenSpawn <= 0)
        {
            int rand = Random.Range(0, meteorPatterns.Length); 
            Instantiate(meteorPatterns[rand], transform.position, Quaternion.identity);
            timeBetweenSpawn = startTimeBetweenSpawn;
            if (startTimeBetweenSpawn > minTime) { startTimeBetweenSpawn -= decreaseTime;  }

        }
        else { timeBetweenSpawn -= Time.deltaTime; }
    }
}
