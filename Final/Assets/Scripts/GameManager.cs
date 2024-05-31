using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] UnitPrefabs;
    private float spawnRangeX = 51;
    private float spawnPosZ = 0;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    public TextMeshProUGUI gameOverText;
    public GameObject pauseScreen;
    private bool paused;

    private void Start()
    {
        InvokeRepeating("SpawnRandomUnit", startDelay, spawnInterval);
        gameOverText.gameObject.SetActive(true);
    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.P))
        {
            ChangePaused();
        }
    }

    void SpawnRandomUnit ()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int UnitIndex = Random.Range(0, UnitPrefabs.Length);
        Instantiate(UnitPrefabs[UnitIndex], spawnPos,
            UnitPrefabs[UnitIndex].transform.rotation);
    }

    public void StartGame()
    {
       
    }

    void ChangePaused()
    {
        if (!paused)
        {
            paused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            paused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
