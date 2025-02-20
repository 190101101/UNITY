using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    private string name = "pepi";
    private string name2 = "ququsi";
    private int num = 50;
    private string data;

    void Start()
    {
        if(name.Equals("pepi"))
        {
            print("yep");
        }

        if(name.EndsWith("pi"))
        {
            print("yep");
        }

        if(name.StartsWith("pe"))
        {
            print("yep");
        }
    }

    void Update()
    {

    }
}

