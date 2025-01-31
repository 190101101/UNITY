using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public string[] childs;
    public List<string> parents;

    void Start()
    {
        foreach(string child in childs)
        {
            print("name: " + child);
        }

        print("the cat name is " + childs[0]);

        parents.Add("kuki");
    }

    void Update()
    {
        
    }
}
