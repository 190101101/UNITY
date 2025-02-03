using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    void Start()
    {
        // Rigidbody added = gameObject.AddComponent<Rigidbody>() as Rigidbody;
        Rigidbody added = gameObject.AddComponent<Rigidbody>();
        added.isKinematic = true;
    }

    void Update()
    {
        
    }
}
