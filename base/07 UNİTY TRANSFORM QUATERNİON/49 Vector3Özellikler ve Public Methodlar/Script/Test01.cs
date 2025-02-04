using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    Vector3 p1;
    Vector3 p2;

    void Start()
    {
        p1 = new Vector3(1f, 1f, 1f);
        p2 = new Vector3(1f, 1f, 1f);

        print(p1.ToString());
    }

    void Update()
    {
        // print(Vector3.Magnitude(transform.position));
        // print(transform.position.normalized);
        print(transform.position.normalized);

    }
}
