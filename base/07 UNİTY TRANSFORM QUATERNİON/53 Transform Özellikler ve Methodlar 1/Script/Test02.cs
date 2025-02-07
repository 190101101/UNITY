using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    void Start()
    {
        // transform.position = new Vector3(2f, 3f, 5f);
        transform.position = new Vector3(
            transform.position.x,
            5f,
            transform.position.z
        );
    }

    void Update()
    {
        
    }
}
