using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    void Start()
    {
        Vector3 pos1 = new Vector3(1f, 2f, 5f);
        Vector3 pos2 = new Vector3(2f, 5f, 1f);

        print("Max: " + Vector3.Max(pos1,pos2));
        print("Min: " + Vector3.Min(pos1,pos2));
        print("Scale: " + Vector3.Scale(pos1,pos2));
    }

    void Update()
    {

    }
}
