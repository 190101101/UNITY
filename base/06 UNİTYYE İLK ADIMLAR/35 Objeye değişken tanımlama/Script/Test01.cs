using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public string name;
    public int age;
    public float salary;
    private string country;
    public bool carRights;

    void Start()
    {
        country = name;
        Debug.Log("name:"+name);
        Debug.Log("age:"+age);
        Debug.Log("salary:"+salary);
        Debug.Log("country:"+country);
        Debug.Log("carRights:"+carRights);

        if(age > 1)
        {
            carRights = true;
            salary = 3000;        
        }

        if(carRights)
        {
            print("have a car right");
        }
        else
        {
            print("no have a car right");
        }
    }

    void Update()
    {
        
    }
}
