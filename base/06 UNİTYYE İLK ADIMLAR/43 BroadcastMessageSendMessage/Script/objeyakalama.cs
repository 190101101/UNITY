using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeyakalama : MonoBehaviour
{
    GameObject benim;
    GameObject[] cokluObje;
    public GameObject disaridan;
    public Material a;

    void Start()
    {
        // Rigidbody ekleyecegim = gameObject.AddComponent<Rigidbody>() as Rigidbody;
        SphereCollider ekleyecegim = gameObject.AddComponent(typeof(SphereCollider)) as SphereCollider;
        ekleyecegim.isTrigger = true;

        /*
        if(gameObject.CompareTag("dushman"))
        {
            Debug.Log("evet dusman");
        }
        else
        {
            Debug.Log("hayir dusman");
        }
        */ 


        /*
        gameObject.SetActive(true);

        if(gameObject.activeSelf)
        {
            Debug.Log(gameObject.activeSelf);
        }
        */ 

        /*
        Camera cam = (Camera)FindObjectOfType(typeof(Camera));
        light light = (light)FindObjectOfType(typeof(light));

        if(cam)
        {
            Debug.Log("evet camera var: "+ cam.name);
        }
        else
        {
            Debug.Log("hayir camera yok");
        }
        */ 


        /*
        CapsuleCollider capsulum = gameObject.GetComponent(typeof(CapsuleCollider)) as CapsuleCollider;
        CapsuleCollider capsulum = gameObject.GetComponent("CapsuleCollider") as CapsuleCollider;
        capsulum.isTrigger = true;

        if(gameObject.GetComponent("CapsuleCollider") as CapsuleCollider)
        {
            gameObject.name = "benim degistirdim";
        }
        */ 


        // disaridan.GetComponent<ilkdosyam>().yas = 60;


        /*
        cokluObje = GameObject.FindGameObjectsWithTag("Player");

        foreach(var item in cokluObje)
        {
            Debug.Log(item);
            item.GetComponent<ilkdosyam>().yas = 3;
        }
        */ 


        /*
        objecti number etmek olmaz!
        benim = GameObject.FindWithTag("Player").GetComponent<ilkdosyam>().yas=15
        */ 

        /*
        benim = GameObject.FindWithTag("Player");
        benim.GetComponent<ilkdosyam>().yas=15;
        */ 


        /*
        benim = GameObject.Find("Ana");
        benim.GetComponent<ilkdosyam>().yas=15;

        GameObject.Find("Ana").GetComponent<ilkdosyam>().yas = 15;
        GameObject.Find("Ana/cocuk").GetComponent<ilkdosyam>().yas = 9;
        */ 
    }
}
