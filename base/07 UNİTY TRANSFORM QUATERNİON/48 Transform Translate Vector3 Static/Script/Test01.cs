using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(new Vector3(0f, 1f, 0f) * 1f * Time.deltaTime);
    }
}
