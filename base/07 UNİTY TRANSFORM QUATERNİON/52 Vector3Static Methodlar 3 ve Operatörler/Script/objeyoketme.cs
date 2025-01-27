using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeyoketme : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2f);
        // Destroy(this); //script file silmek.
        Destroy(GetComponent<CapsuleCollider>());
    }
}
