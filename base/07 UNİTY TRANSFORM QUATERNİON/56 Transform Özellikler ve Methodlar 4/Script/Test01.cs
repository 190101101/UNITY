using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public Transform parent;
    public GameObject child;
    
    void Start()
    {
        child.transform.SetParent(parent);
        // child position = false
        // child.transform.SetParent(parent, false); 
    }

    void Update()
    {
        
    }
}
