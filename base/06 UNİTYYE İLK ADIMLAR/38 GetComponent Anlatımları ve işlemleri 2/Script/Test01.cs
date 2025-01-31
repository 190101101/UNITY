using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    void Start()
    {
        GetComponentInChildren<AudioSource>().mute = true;
        GetComponentInChildren<CapsuleCollider>().isTrigger = true;

        // GetComponentsInChildren<CapsuleCollider>();
        // GetComponentsInParent<CapsuleCollider>();

    }

    void Update()
    {
        
    }
}
