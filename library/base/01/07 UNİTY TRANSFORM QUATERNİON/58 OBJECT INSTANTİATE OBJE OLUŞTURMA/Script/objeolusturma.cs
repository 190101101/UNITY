using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeolusturma : MonoBehaviour
{
    public GameObject olusacakobjem;
    private float zaman;

    void Start()
    {
        zaman = 0;
        // Instantiate(olusacakobjem);
        // Instantiate(olusacakobjem, transform);
        // Instantiate(olusacakobjem, transform.position, transform.rotation);
        // Instantiate(olusacakobjem, transform.position, Quaternion.identity);
        // Instantiate(olusacakobjem, transform.position, Quaternion.identity);
        // Instantiate(olusacakobjem, new Vector3(2f, 3f, 5f), Quaternion.identity);
        // Instantiate(olusacakobjem, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity);
        // Instantiate(olusacakobjem, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity);
        // GameObject ornekobje = Instantiate(olusacakobjem, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity);
        // ornekobje.GetComponent<BoxCollider>().enabled = false;
    }

    void Update()
    {
        if(zaman >= 2)
        {
            GameObject ornekobje = Instantiate(olusacakobjem, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity);
            ornekobje.GetComponent<BoxCollider>().enabled = false;
            zaman = 0;
        }
        else
        {
            zaman += Time.deltaTime;
        }
    }
}
