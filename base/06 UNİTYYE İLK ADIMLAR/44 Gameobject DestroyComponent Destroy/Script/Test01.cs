using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    void Start()
    {
        // Destroy(gameObject, 2f);
        // Destroy(this); script file silmek ucun.
        Destroy(GetComponent<CapsuleCollider>(), 2f);
    }

    void Update()
    {
        
    }
}
