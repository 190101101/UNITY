using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public Transform aim1;
    public Transform aim2;

    void Start()
    {

    }

    void Update()
    {
        float difference = Vector3.Distance(aim1.position, transform.position);
        print("difference: " +difference); 

    }
}
