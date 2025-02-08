using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public Transform aim1;
    public Transform aim2;
    
    void Start()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            print(transform.GetChild(i).name);

            if(transform.GetChild(i).name == "Capsule")
            {
                transform.GetChild(i).GetComponent<CapsuleCollider>().enabled = false;
            }
        }
    }

    void Update()
    {
        
    }
}
