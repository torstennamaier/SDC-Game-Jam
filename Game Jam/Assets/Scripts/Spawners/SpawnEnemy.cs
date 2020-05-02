﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    //This is an array we manually can add different enemy prefabs to, in case we have multiple enemy types
    public GameObject[] enemyPrefabs;
    //This is how long it takes before we start spawning enemies in seconds
    public float spawnDelay = 2.0f;
    //This is how many seconds it is between each time we spawn an enemy
    public float spawnInterval = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        //When the game starts then we starts spawning enemies from the array assigned every spawnInterval number of seconds
        InvokeRepeating("SpawnRandomEnemy", spawnDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {

    }
    //We will spawn a randomly selected enemy from the position of the object the script is attached to when this is called
    void SpawnRandomEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 spawnPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);

    }

}
