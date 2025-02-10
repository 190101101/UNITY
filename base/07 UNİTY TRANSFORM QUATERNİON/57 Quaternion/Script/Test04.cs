using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test04 : MonoBehaviour
{
    public Transform aim1;

    void Start()
    {
        // transform.rotation = Quaternion.Euler(90,0,0);
        // transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);
    }

    void Update()
    {
        // transform.rotation = Quaternion.Inverse(aim1.rotation);
        // transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);
    }
}

