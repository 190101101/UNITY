using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    GameObject my;

    void Start()
    {
        my = GameObject.FindWithTag("parent");
        my.GetComponent<Test02>().age = 2;
    }

    void Update()
    {
        
    }
}
