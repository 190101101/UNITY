using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test04 : MonoBehaviour
{
    public Transform a;
    public Transform b;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(new Vector3(2f,0f,0f) * Time.deltaTime * 20f);
        transform.Rotate(new Vector3(2f,0f,0f), Space.World);
        transform.Rotate(new Vector3(2f,0f,0f), Space.Self);
    }
}
