using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    [Multiline(7)]
    public string text;

    [Tooltip("my note")]
    public bool status;

    [Header("player data")]
    public string health;
    public string money;
    public string level;

    [Header("enemy data")]
    public string enemy_health;
    public string enemy_money;
    public string enemy_level;

    [ContextMenu("my menu 1", false, 1)]
    void myMenu1()
    {
        print("from Context Menu 1");
    }

    [ContextMenu("my menu 2", false, 1)]
    void myMenu2()
    {
        print("from Context Menu 2");
    }

    void Start()
    {

    }

    void Update()
    {

    }
}

