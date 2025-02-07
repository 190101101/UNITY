using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    public Transform aim1;
    public Transform aim2;

    void Start()
    {

    }

    void Update()
    {
        Vector3 distance = aim1.position - transform.position;
        float angle = Vector3.Angle(distance, transform.forward);
        Debug.Log(angle);

        if(angle < 5f)
        {
            print("done");
        }
    }
}
