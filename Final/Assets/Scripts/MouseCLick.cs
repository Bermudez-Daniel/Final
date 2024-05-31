using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCLick : MonoBehaviour
{
    public GameObject UnitPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(UnitPrefab, transform.position, Quaternion.identity);
        }
    }
}
