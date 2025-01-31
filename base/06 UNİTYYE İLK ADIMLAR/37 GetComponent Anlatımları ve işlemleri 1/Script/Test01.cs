using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    CapsuleCollider[] myCapsules;

    void Start()
    {
        myCapsules = GetComponents<CapsuleCollider>();

        for(int i = 0; i < myCapsules.Length; i++)
        {
            myCapsules[i].enabled = false;
            myCapsules[i].isTrigger = true;
            myCapsules[i].height = 7;    
        }
    }

    void Update()
    {
        
    }
}
