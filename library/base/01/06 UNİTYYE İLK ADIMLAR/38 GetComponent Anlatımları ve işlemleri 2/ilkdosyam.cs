using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ilkdosyam : MonoBehaviour
{
    CapsuleCollider Capsulum;

    // Start is called before the first frame update
    void Start()
    {
        /*
        GetComponentInParent<AudioSource>().mute = true;
        GetComponentInParent<Rigidbody>().mass = 3f;
        */ 

        /*
        GetComponentInChildren<AudioSource>().mute = true;
        GetComponentInChildren<CapsuleCollider>().enabled = false;
        */ 


        // GetComponentsInChildren
        // GetComponentsInParent




        /*
        Capsulum = GetComponent<CapsuleCollider>();

        Capsulum.enabled = false;
        Capsulum.isTrigger = true;
        Capsulum.height = 7;


        CapsuleCollider[] capsullerim = GetComponents<CapsuleCollider>();

        for(int i = 0; i < capsullerim.Length; i++)
        {
            Debug.Log(capsullerim[i]);
            capsullerim[i].enabled = false;
        }
        */ 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
