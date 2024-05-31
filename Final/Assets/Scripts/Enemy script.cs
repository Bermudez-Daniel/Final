using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyscript : MonoBehaviour
{
    public GameObject Unit;
    public GameObject Enemy;
    public float speed;
    // Start is called befre the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Enemy.transform.position = Vector3.MoveTowards(Enemy.transform.position, Unit.transform.position, speed);
    }
}
