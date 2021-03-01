﻿using System.Collections;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float spawnDelay = .3f;

    public GameObject car;

    public Transform[] spawnPoints;

    float nextTimeToSpawn = 0f;



    private void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }

        void SpawnCar()
        {
            int randomIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[randomIndex];

            //Destroys instantiated car gameObject
            Destroy(Instantiate(car, spawnPoint.position, spawnPoint.rotation), 3f);
            
        }
    }

    
}
