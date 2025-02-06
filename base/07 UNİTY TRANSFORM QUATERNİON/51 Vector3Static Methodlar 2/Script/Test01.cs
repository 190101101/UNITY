using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public Transform aim1;
    public Transform aim2;
    private float startTime;

    void Start()
    {
        startTime = Time.time;

        /*
        Time.time
        Time.deltaTime
        Time.timeScale
        */ 
    }

    void Update()
    {
        transform.position = Vector3.Lerp(aim1.position, aim2.position, (Time.time - startTime) * .2f);
    }
}
