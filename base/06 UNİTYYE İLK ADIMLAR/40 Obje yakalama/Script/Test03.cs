using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    GameObject my;
    GameObject[] myObjects;

    void Start()
    {
        myObjects = GameObject.FindGameObjectsWithTag("Player");

        foreach(var item in myObjects)
        {
            item.GetComponent<Test02>().age = 2;
        }
    }

    void Update()
    {
        
    }
}
