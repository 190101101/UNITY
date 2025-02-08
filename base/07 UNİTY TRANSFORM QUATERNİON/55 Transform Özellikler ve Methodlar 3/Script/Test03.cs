using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    public Transform aim1;
    public Transform aim2;
    
    void Start()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            print(transform.GetChild(i).name);

            if(i==1)
            {
                transform.GetChild(i).GetComponent<CapsuleCollider>().enabled = false;
            }
        }
    }

    void Update()
    {
        
    }
}
