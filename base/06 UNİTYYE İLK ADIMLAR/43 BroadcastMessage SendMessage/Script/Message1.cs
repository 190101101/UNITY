using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message1 : MonoBehaviour
{
    void Start()
    {
        /*
        gameObject.SendMessage();
        gameObject.BroadcastMessage();
        */ 

        // SendMessageOptions.DontRequireReceiver text = false;
        // gameObject.SendMessage("click", "pepi", SendMessageOptions.DontRequireReceiver);
        gameObject.SendMessage("click");
        gameObject.BroadcastMessage("click2");
    }

    void click()
    {
        print("clicked");
    }

    void click2()
    {
        print("clicked 2");
    }

    void Update()
    {
        
    }
}
