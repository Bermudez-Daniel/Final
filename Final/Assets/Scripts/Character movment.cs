using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactermovment : MonoBehaviour
{
    public GameObject Player2;
    public GameObject Unit;
    public float speed;
    // Start is called befre the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Unit.transform.position = Vector3.MoveTowards(Unit.transform.position, Player2.transform.position, speed);
    }
}
