using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mycube : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 8f);
    }

    void Update()
    {
        transform.Translate(Vector3.forward);
    }
}
