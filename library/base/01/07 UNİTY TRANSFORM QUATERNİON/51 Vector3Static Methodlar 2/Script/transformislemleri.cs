using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformislemleri : MonoBehaviour
{
    // static methods
    public Transform hedef1;
    public Transform hedef2;
    private float baslangiczamani;

    void Start()
    {
        baslangiczamani = Time.time;
        
        /*
        Time.time
        Time.deltaTime
        Time.timeScale
        */ 

        /*
        Debug.Log("ben startdan geliyorum" + Time.time);
        Debug.Log("ben startdan geliyorum" + Time.deltaTime);
        */ 
    }

    void Update()
    {
        /*
        Time.timeScale = .5f;
        Time.timeScale = 0f;
        Debug.Log(Time.time);
        Debug.Log(Time.deltaTime);
        */ 

        // lerp
        Time.timeScale = .5f;
        transform.position = Vector3.Lerp(hedef1.position, hedef2.position,(Time.time - baslangiczamani) * .2f);


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
