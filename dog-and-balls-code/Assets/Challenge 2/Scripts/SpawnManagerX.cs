﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    public float spawnLimitXLeft = -25;
    public float spawnLimitXRight = 15;
    public float spawnPosY = 30;

    // Start is called before the first frame update
    void Start()
    {   
        float startDelay = 1.0f;
        float spawnInterval = Random.Range(3, 5);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int ballIndex = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
