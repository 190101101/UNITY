using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesaj1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        gameObject.SendMessage();
        gameObject.BroadcastMessage();   
        */
        // gameObject.SendMessage("ekranabas", "pepi", SendMessageOptions.DontRequireReceiver);
        gameObject.SendMessage("ekranabas", "pepi");
        gameObject.BroadcastMessage("ekranabas2", "pepi");
    }

    void ekranabas(string name)
    {
        Debug.Log("hello " + name);
    }

    void ekranabas2(string name)
    {
        Debug.Log("ana obje: hello 2 " + name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
