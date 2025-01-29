using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformislemleri : MonoBehaviour
{
    // static methods
    public Transform hedef1;
    public Transform hedef2;

    void Start()
    {
        // transform.position = new Vector3(2f, 3f, 5f);

        /*
        transform.position = new Vector3(
            transform.position.x, 
            transform.position.y+3f, 
            transform.position.z
        );
        */ 

        hedef1.transform.Rotate(90f,0f,2f, Space.Self);
        hedef2.transform.Rotate(90f,0f,2f, Space.World);
    }

    void Update()
    {
        // hedef1.transform.Rotate(2f,4f,1f, Space.Self);
        // hedef2.transform.Rotate(2f,4f,2f, Space.World);

        // transform.Rotate(new Vector3(0f,0f,1f), Space.World);
        // transform.Rotate(new Vector3(0f,0f,1f), Space.Self);
        // transform.Rotate(new Vector3(0f,0f,1f) * 1f);

        // transform.Translate(new Vector3(0f, 0.1f, 0f));
        // transform.Translate(transform.forward * Time.deltaTime * 1f);
    }
}
