using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeyakalama : MonoBehaviour
{
    GameObject benim;
    void Start()
    {
        // objecti number etmek olmaz!
        // benim = GameObject.FindWithTag("Player").GetComponent<ilkdosyam>().yas=15

        benim = GameObject.FindWithTag("Player");
        benim.GetComponent<ilkdosyam>().yas=15;


        /*
        benim = GameObject.Find("Ana");
        benim.GetComponent<ilkdosyam>().yas=15;

        GameObject.Find("Ana").GetComponent<ilkdosyam>().yas = 15;
        GameObject.Find("Ana/cocuk").GetComponent<ilkdosyam>().yas = 9;
        */ 
    }
}
