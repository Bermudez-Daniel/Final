using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactermovment : MonoBehaviour
{
    public GameObject Castle;
    public GameObject Unit;
    public float speed;
    // Start is called befre the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Unit.transform.position = Vector3.MoveTowards(Unit.transform.position, Castle.transform.position, speed);
    }
}
