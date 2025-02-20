using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    void Start()
    {
        print("Abs: " + Mathf.Abs(-4.5f));
        print("Floor: " + Mathf.Floor(4.5f));
        print("Ceil: " + Mathf.Ceil(4.5f));
        print("Round: " + Mathf.Round(4.5f));
        print("Clamp: " + Mathf.Clamp(-5, 1, 100));
        print("Clamp01: " + Mathf.Clamp01(4.5f));
        print("Max: " + Mathf.Max(4.5f, 3f, 6f));
        print("Min: " + Mathf.Min(4.5f, 3f, 6f));
    }

    void Update()
    {

    }
}

