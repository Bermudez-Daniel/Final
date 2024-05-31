using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] UnitPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 0;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomUnit", startDelay, spawnInterval);
    }

    void Update()
    {
       
    }

    void SpawnRandomUnit ()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int UnitIndex = Random.Range(0, UnitPrefabs.Length);
        Instantiate(UnitPrefabs[UnitIndex], spawnPos,
            UnitPrefabs[UnitIndex].transform.rotation);
    }
}
