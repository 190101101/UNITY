using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    GameObject my;
    public GameObject fromOutside;
    public Material a;

    void Start()
    {
        // gameObject.GetComponent<CapsuleCollider>().enabled = false;
        // CapsuleCollider capsulum = gameObject.GetComponent(typeof(CapsuleCollider)) as CapsuleCollider;
        CapsuleCollider capsulum = gameObject.GetComponent("CapsuleCollider") as CapsuleCollider;
        capsulum.enabled = false;
        // fromOutside.GetComponent<Test02>().age = 2;

        if(gameObject.GetComponent<CapsuleCollider>())
        {
         gameObject.name = "newname";
        }
    }

    void Update()
    {
        
    }
}
