using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ornekobjem : MonoBehaviour
{
    private void start()
    {
        Destroy(gameObject, 2f);
    }

    void Update()
    {
        transform.Translate(Vector3.forward);
    }
}
