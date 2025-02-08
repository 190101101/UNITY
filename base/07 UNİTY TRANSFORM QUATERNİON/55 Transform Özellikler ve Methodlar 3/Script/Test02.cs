using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    public Transform aim1;
    public Transform aim2;
    
    void Start()
    {
        GameObject p1 = transform.Find("GameObject").gameObject;
        p1.name = "GameObjectChanged";

        GameObject p2 = transform.Find("GameObjectChanged/Cube").gameObject;
        p2.name = "name is changed 2";

        print(transform.childCount);
        print(transform.hierarchyCount);
    }

    void Update()
    {
        
    }
}
