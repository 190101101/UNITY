﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ilkdosyam : MonoBehaviour
{
    public string ad;
    public int yas;
    public float maas;
    private string memleket;
    public bool arabavarmi;
    // Start is called before the first frame update
    void Start()
    {
        memleket = ad;
        /*
        Debug.Log(ad);
        Debug.Log(yas);
        Debug.Log(maas);
        Debug.Log(memleket);
        Debug.Log(arabavarmi);
        */ 

        if(yas >= 18)
        {
            arabavarmi = true;
            maas = 6000f;
        }
        else
        {
            arabavarmi = false;
            maas = 1000f;
        }

        if(arabavarmi)
        {
            Debug.Log("evet");
        }
        else
        {
            Debug.Log("hayir");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
