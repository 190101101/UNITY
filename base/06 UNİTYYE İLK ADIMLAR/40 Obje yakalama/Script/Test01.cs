using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public GameObject fromOutside;
    public Material a;

    void Start()
    {
        fromOutside.GetComponent<Test02>().age = 2;
    }

    void Update()
    {
        
    }
}
