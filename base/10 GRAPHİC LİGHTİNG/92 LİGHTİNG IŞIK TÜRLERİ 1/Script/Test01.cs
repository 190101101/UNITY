using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public Camera MainCam;
    public Camera Camera2;
    public Camera Camera3;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            print("clicked KeyCode.Z");
            MainCam.enabled = false;
            Camera2.enabled = true;
            Camera2.fieldOfView = 15f;
            Camera3.enabled = false;
            
        }

        if(Input.GetKeyDown(KeyCode.X))
        {
            print("clicked KeyCode.X");
            MainCam.enabled = false;
            Camera2.enabled = false;
            Camera3.enabled = true;
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            print("clicked KeyCode.C");
            MainCam.enabled = true;
            Camera2.enabled = false;
            Camera3.enabled = false;
        }
    }
}
