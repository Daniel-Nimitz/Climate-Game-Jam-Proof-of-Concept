using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] encounterPrefabs;
    private float startDelay = 2.0f;
    private float spawnInterval = 2.0f;
    private Vector3 laneOne = new Vector3(40, 3, 0);
    private Vector3 laneTwo = new Vector3(40, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEncounter", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SpawnRandomEncounter()
    {
        float spawnLane = Random.Range(0,1.5f);
        if (spawnLane > 0.5)
        {
            int prefabIndex = Random.Range(0, 2);
            Vector3 spawnPos = laneOne;
            Instantiate(encounterPrefabs[prefabIndex], spawnPos, encounterPrefabs[prefabIndex].transform.rotation);
        }
        else {
            int prefabIndex = Random.Range(0, encounterPrefabs.Length);
            Vector3 spawnPos = laneTwo;
            Instantiate(encounterPrefabs[prefabIndex], spawnPos, encounterPrefabs[prefabIndex].transform.rotation);
        }
    }
}
