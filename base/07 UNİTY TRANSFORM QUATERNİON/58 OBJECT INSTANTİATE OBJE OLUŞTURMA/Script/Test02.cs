using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    public GameObject example;

    void Start()
    {
        Instantiate(example);
        Instantiate(example, transform);
        Instantiate(example, transform.position, transform.rotation);
        Instantiate(example, transform.position, Quaternion.identity);
        Instantiate(example, new Vector3(1f, 3f, 5f), Quaternion.identity);
        Instantiate(example, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity);
        GameObject p1object = Instantiate(example, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity);
        p1object.GetComponent<BoxCollider>().enabled = false;
    }

    void Update()
    {

    }
}

