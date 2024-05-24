using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    [SerializeField]
    private int index;
    [SerializeField]
    private string name;
    [SerializeField]
    private Sprite icon;
    [SerializeField]
    private int cost;
    [SerializeField]
    private GameObject prefab;

    public Sprite Icon
    {
        get { return icon; }
        set { icon = value; }
    }
    public int Index
    {
        get { return index; }
        set { index = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Cost
    {
        get { return cost; }
        set { cost = value; }
    }
    public GameObject Prefab
    {
        get { return prefab; }
        set { prefab  = value; }
    }
}
