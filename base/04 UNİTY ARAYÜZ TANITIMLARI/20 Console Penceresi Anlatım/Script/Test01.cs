using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    string a;
    int b;
    float c;
    
    void Start()
    {
        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(c);
        Debug.LogError("error");
        Debug.LogWarning("warning");
    }

    void Update()
    {
        
    }
}
