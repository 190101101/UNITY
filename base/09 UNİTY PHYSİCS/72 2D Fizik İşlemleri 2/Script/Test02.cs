using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Enter: "+ collision.gameObject.name);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        print("Stay: "+ collision.gameObject.name);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        print("Exit: "+ collision.gameObject.name);
    }

}
