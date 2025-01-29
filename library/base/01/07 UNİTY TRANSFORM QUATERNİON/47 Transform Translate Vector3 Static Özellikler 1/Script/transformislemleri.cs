using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformislemleri : MonoBehaviour
{
    Vector2 a;
    Vector3 b;
    Vector4 c;
    Quaternion d;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("position:"+transform.position);
        Debug.Log("rotation:"+transform.rotation);
        Debug.Log("scale:"+transform.localScale);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.one * Time.deltaTime);
        // transform.Translate(Vector3.zero * Time.deltaTime); ?
        // transform.Translate(Vector3.up * Time.deltaTime);
        // transform.Translate(Vector3.back * 5f * Time.deltaTime);
        // transform.Translate(new Vector3(0f,1f,0f) * Time.deltaTime);
        // transform.Translate(new Vector3(0f,1f,0f) * 5f * Time.deltaTime);
    }
}
