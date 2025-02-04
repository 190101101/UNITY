using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
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
        print("position: " + transform.position);
        transform.Translate(new Vector3(0f, 1f, 0f) * Time.deltaTime);
        transform.Translate(Vector3.back * Time.deltaTime);
        transform.Translate(Vector3.back * 1f * Time.deltaTime);
        transform.Translate(new Vector3(0f, -1f, 0f) * 1f * Time.deltaTime);
        transform.Translate(Vector3.one * 1f * Time.deltaTime);
        transform.Translate(Vector3.zero * 1f * Time.deltaTime);
    }
}
