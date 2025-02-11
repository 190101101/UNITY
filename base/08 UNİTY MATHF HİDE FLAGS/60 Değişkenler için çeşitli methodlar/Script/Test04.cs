using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test04 : MonoBehaviour
{
    void Start()
    {
        int num = 99;
        string text = " this is a text ";

        print(num.ToString());
        print(text.ToUpper());
        print(text.ToLower());
        print(text.Replace(" ", "|"));
        print(text.Trim());
        print(text.TrimStart());
        print(text.TrimEnd());
        print(text.TrimStart().TrimEnd());
        print(text.Substring(2, 10));

    }

    void Update()
    {

    }
}

