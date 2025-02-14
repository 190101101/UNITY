using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
    	print("interaction have");
    }

    private void OnCollisionStay(Collision collision)
    {
        print("interaction it continues");
    }

    private void OnCollisionExit(Collision collision)
    {
        print("interaction finish");
    }
}



