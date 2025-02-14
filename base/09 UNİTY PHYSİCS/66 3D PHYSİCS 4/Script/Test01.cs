using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // if(other.CompareTag("2"))
        if(other.gameObject.name == "2")
        {
            // Destroy(gameObject);
            Destroy(other.gameObject);
            print("interaction have");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "2")
        {
            print("interaction it continues");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "2")
        {
            print("interaction finish");
        }
    }
}