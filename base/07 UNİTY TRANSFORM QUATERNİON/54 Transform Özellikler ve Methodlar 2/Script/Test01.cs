using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public Transform aim1;
    public Transform aim2;
    
    void Start()
    {
        print(aim1.transform.localPosition);
        print(aim1.transform.localRotation);
        print(aim1.transform.localScale);
    }

    void Update()
    {

    }
}
