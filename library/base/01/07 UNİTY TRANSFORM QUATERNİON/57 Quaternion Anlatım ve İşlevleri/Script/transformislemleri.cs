using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformislemleri : MonoBehaviour
{
    public Transform hedef;

    void Start()
    {
        // transform.rotation = Quaternion.Euler(90, 0, 0);
        // transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);

        /*
        Vector3 bizimpozisyon = new Vector3(140, 70, 90);
        Quaternion yenipozisyon = Quaternion.Euler(bizimpozisyon);
        transform.rotation = yenipozisyon;
        */ 

        // Quaternion.identity;
        // transform.rotation = Quaternion.identity;
    }

    void Update()
    {
        /*
        Vector3 fark = hedef.position - transform.position;
        transform.rotation = Quaternion.LookRotation(fark, Vector3.up);

        float angle = Quaternion.Angle(transform.rotation, hedef.rotation);
        print(angle);

        transform.rotation = Quaternion.Inverse(hedef.rotation);
        */ 
    }
}
