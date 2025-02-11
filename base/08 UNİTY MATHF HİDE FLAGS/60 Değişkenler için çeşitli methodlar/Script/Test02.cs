using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    private string name = "pepi";
    private string name2 = "ququsi";
    private int num = 50;
    private string data;

    void Start()
    {
        print(name.GetType());
        print(num.GetType());
        
        string copyed = (string) name.Clone();
        print(name);
        print(copyed);
    }

    void Update()
    {

    }
}

