using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    void Start()
    {
        print("position: " + transform.position);
        print("rotation: " + transform.rotation);
        print("localScale: " + transform.localScale);
        transform.Translate(new Vector3(1f, 1f, 1f));
    }

    void Update()
    {
        // print("position: " + transform.position);

    }
}
