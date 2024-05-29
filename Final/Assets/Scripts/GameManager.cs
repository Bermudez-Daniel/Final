using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] unitprefabs;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int unitIndex = Random.Range(0, unitprefabs.Length);
            Instantiate(unitIndex), new Vector3(0, 0, 20), unitPrefabs[unitIndex].transform.rotation);
        }
    }
}
