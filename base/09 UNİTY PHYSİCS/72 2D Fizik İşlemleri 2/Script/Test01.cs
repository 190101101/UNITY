using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        print("Enter: "+ trigger.gameObject.name);
    }

    private void OnTriggerStay2D(Collider2D trigger)
    {
        print("Stay: "+ trigger.gameObject.name);
    }

    private void OnTriggerExit2D(Collider2D trigger)
    {
        print("Exit: "+ trigger.gameObject.name);
    }

}
