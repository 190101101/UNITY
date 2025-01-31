using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    CapsuleCollider myCapsule;

    void Start()
    {
        myCapsule = GetComponent<CapsuleCollider>();
        myCapsule.enabled = false;
        myCapsule.isTrigger = true;
        myCapsule.height = 7;
    }

    void Update()
    {
        
    }
}
