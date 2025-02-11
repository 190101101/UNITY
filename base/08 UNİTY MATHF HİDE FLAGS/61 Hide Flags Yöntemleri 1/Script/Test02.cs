using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    public int age;
    [HideInInspector]
    public string name;

    void Start()
    {
        // gameObject.hideFlags = HideFlags.HideInHierarchy;
        // gameObject.hideFlags = HideFlags.HideInInspector;
        // gameObject.hideFlags = HideFlags.NotEditable;
        gameObject.hideFlags = HideFlags.DontSave;
    }

    void Update()
    {

    }
}

