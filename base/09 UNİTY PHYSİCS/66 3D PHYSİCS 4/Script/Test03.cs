using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "2")
        {
        	print("interaction have");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.name == "2")
        {
            print("interaction it continues");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "2")
        {
            print("interaction finish");
        }
    }
}



