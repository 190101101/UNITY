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

    }

    void Update()
    {
        /*
        // distance
        float fark = Vector3.Distance(hedef1.position, transform.position);
        Debug.Log("fark shudur: "+fark);
        */ 

        /*
        // angle
        Vector3 mesafe = hedef1.position - transform.position;
        float angle = Vector3.Angle(mesafe, transform.forward);
        float angle = Vector3.Angle(mesafe, transform.up);
        Debug.Log(angle);

        if(angle < 5f)
        {
            Debug.Log("aci saglandi");
        }
        */ 

    }
}
