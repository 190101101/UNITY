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

        Vector3 birincipoz = new Vector3(4f,2f,3f);
        Vector3 ikincipoz = new Vector3(3f,5f,1f);

        print(birincipoz-ikincipoz);
        print(birincipoz+ikincipoz);
        print(birincipoz/2f);
        print(birincipoz*2f);


        /*
        print("min: " +Vector3.Max(birincipoz, ikincipoz));
        print("max: " +Vector3.Max(birincipoz, ikincipoz));
        print("scale: " +Vector3.Scale(birincipoz, ikincipoz));
        */ 

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
        /*
        Time.timeScale = .5f;
        transform.position = Vector3.Lerp(hedef1.position, hedef2.position,(Time.time - baslangiczamani) * .2f);
        */ 


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
