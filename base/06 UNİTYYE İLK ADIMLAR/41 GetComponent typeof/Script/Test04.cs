using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test04 : MonoBehaviour
{
    void Start()
    {
        Camera camera = (Camera)FindObjectOfType(typeof(Camera)); 

        if(camera)
        {
            print("came is have");
            print(camera.name);
        }
    }

    void Update()
    {
        
    }
}
