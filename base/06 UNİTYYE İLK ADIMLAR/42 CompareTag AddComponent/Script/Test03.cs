using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    void Start()
    {
        print(gameObject.CompareTag("Player"));

        if(gameObject.CompareTag("Player"))
        {
            print("player");
        }
    }

    void Update()
    {
        
    }
}
