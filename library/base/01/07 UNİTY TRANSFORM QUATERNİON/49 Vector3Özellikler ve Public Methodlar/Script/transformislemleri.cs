using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformislemleri : MonoBehaviour
{
    /*
    Vector2 a;
    Vector3 b;
    Vector4 c;
    Quaternion d;
    */ 

    Vector3 pozisyonum1;
    Vector3 pozisyonum2;


    // Start is called before the first frame update
    void Start()
    {
        pozisyonum1 = new Vector3(1f,2.3f,1f);
        pozisyonum2 = new Vector3(1f,2f,1f);

        /*
        Debug.Log("position:"+transform.position);
        Debug.Log("rotation:"+transform.rotation);
        Debug.Log("scale:"+transform.localScale);
        */ 

        /*
        if(Vector3.Equals(pozisyonum1, pozisyonum2))
        {
            Debug.Log("evet pozisyon ayni");
        } else
        {
            Debug.Log("hayir pozisyon ayni degil");
        }
        */ 

        if(pozisyonum1 == pozisyonum2)
        {
            Debug.Log("evet pozisyon ayni");
        } else
        {
            Debug.Log("hayir pozisyon ayni degil");
        }

        Debug.Log(pozisyonum1.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(transform.position.normalized);


        /*
        Debug.Log(Vector3.SqrMagnitude(transform.position));
        Debug.Log(Vector3.Magnitude(transform.position));
        */ 

        /*
        transform.Translate(Vector3.one * Time.deltaTime);
        transform.Translate(Vector3.zero * Time.deltaTime); ?
        transform.Translate(Vector3.up * Time.deltaTime);
        transform.Translate(Vector3.back * 5f * Time.deltaTime);
        transform.Translate(new Vector3(0f,1f,0f) * Time.deltaTime);
        transform.Translate(new Vector3(0f,1f,0f) * 5f * Time.deltaTime);
        */ 
    }
}
