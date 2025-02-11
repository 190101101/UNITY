using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    public GameObject example;

    void Start()
    {
        GameObject p1object = Instantiate(example, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity);
        p1object.GetComponent<BoxCollider>().enabled = false;
    }

    void Update()
    {

    }
}

// 14.20 deq