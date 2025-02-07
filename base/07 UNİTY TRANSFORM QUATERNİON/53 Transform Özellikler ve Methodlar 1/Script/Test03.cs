using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        // transform.Translate(new Vector3(2f, 3f, 1f));
        transform.Translate(transform.up * Time.deltaTime * 2f);
    }
}
