using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public GameObject example;
    private float t1;

    void Start()
    {
        t1 = 0;
    }

    void Update()
    {
        if(t1 >= 2)
        {
            GameObject myCube = Instantiate(example, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity);
            myCube.GetComponent<BoxCollider>().enabled = false;
            t1 = 0;
        }
        else
        {
            t1 += Time.deltaTime;
        }
    }
}

