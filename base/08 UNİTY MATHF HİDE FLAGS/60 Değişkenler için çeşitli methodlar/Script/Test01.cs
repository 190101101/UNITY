using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    void Start()
    {
        string text = "this*is a text";
        string[] cut = text.Split('*');

        foreach(var item in cut)
        {
            print(item);
        }

    }

    void Update()
    {

    }
}

