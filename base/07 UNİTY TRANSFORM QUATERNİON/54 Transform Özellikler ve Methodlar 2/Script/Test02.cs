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
        aim2.transform.LookAt(aim1);
        aim2.transform.LookAt(aim1, Vector3.left);
    }
}
