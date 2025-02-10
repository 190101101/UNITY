using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    public Transform aim1;

    void Start()
    {

    }

    void Update()
    {
        Vector3 difference = aim1.position - transform.position;
        transform.rotation = Quaternion.LookRotation(difference, Vector3.up);
    }
}
