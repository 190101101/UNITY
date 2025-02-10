using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test05 : MonoBehaviour
{
    public Transform aim1;

    void Start()
    {
        Vector3 p1 = new Vector3(140, 70, 90);
        Quaternion p2 = Quaternion.Euler(p1);

        transform.rotation = p2;
        print(p2);
    }

    void Update()
    {
        
    }
}

