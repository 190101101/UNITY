using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    void Start()
    {
        GetComponentInParent<AudioSource>().mute = true;
        GetComponentInParent<Rigidbody>().mass = 10f;
        GetComponentInParent<CapsuleCollider>().enabled = false;
    }

    void Update()
    {
        
    }
}
