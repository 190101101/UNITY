using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformislemleri : MonoBehaviour
{
    // static methods
    // public Transform hedef1;
    // public Transform hedef2;

    void Start()
    {
        /*
        GameObject aramasonu = transform.Find("GameObject").gameObject;
        GameObject aramasonu = transform.Find("GameObject/Cube").gameObject;
        aramasonu.name="ben degishtirdim";
        
        Debug.Log(transform.childCount);
        Debug.Log(transform.hierarchyCount);
        */ 

        for(int i = 0; i < transform.childCount; i++)
        {
            Debug.Log(transform.GetChild(i).name);

            if(transform.GetChild(i).name == "Capsule")
            {
                transform.GetChild(i).GetComponent<CapsuleCollider>().enabled = false;
            }

            /*
            if(i == 1)
            {
                transform.GetChild(i).GetComponent<CapsuleCollider>().enabled = false;
            }
            */ 

        }


        /*
        print(hedef1.transform.localPosition);
        print(hedef1.transform.localScale);

        transform.position = new Vector3(2f, 3f, 5f);
        
        transform.position = new Vector3(
            transform.position.x, 
            transform.position.y+3f, 
            transform.position.z
        );
        */ 

        /*
        hedef1.transform.Rotate(90f,0f,2f, Space.Self);
        hedef2.transform.Rotate(90f,0f,2f, Space.World);
        */ 
    }

    void Update()
    {
        /*
        hedef2.transform.LookAt(hedef1);
        hedef2.transform.LookAt(hedef1,Vector3.left);
        */ 

        /*
        hedef1.transform.Rotate(2f,4f,1f, Space.Self);
        hedef2.transform.Rotate(2f,4f,2f, Space.World);
        */ 

        /*
        transform.Rotate(new Vector3(0f,0f,1f), Space.World);
        transform.Rotate(new Vector3(0f,0f,1f), Space.Self);
        transform.Rotate(new Vector3(0f,0f,1f) * 1f);
        */ 

        /*
        transform.Translate(new Vector3(0f, 0.1f, 0f));
        transform.Translate(transform.forward * Time.deltaTime * 1f);
        */ 
    }
}
