using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    void Start()
    {
        Vector3 pos1 = new Vector3(1f, 2f, 5f);
        Vector3 pos2 = new Vector3(2f, 5f, 1f);

        print(pos1 - pos2);
        print(pos1 + pos2);
        print(pos1 / 2f);
        print(pos1 * 2f);
    }

    void Update()
    {

    }
}
