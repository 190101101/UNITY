using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		// Destroy(other.gameObject);
		Destroy(gameObject);
		// other.CompareTag("Enemy");
		print("enter: "+other.gameObject.name);
	}

	private void OnTriggerStay(Collider other)
	{
		print("stay: "+other.gameObject.name);
	}

	private void OnTriggerExit(Collider other)
	{
		print("exit: "+other.gameObject.name);
	}
}
