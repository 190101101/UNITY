using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public Transform aim1;
    public Transform aim2;
    
    void Start()
    {
        aim1.transform.Rotate(new Vector3(90f,0f,0f), Space.World);
        aim2.transform.Rotate(new Vector3(90f,0f,0f), Space.Self);
    }

    void Update()
    {
        aim1.transform.Rotate(new Vector3(2f,4f,1f), Space.World);
        aim2.transform.Rotate(new Vector3(2f,4f,1f), Space.Self);
    }
}
