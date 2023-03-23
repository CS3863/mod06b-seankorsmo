using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 20.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos = new Vector3(UnityEngine.Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            //Randomly generate animal index and spawn position
            int animalIndex = UnityEngine.Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
        
    }
}
