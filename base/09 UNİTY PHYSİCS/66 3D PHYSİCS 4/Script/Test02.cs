using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		print("enter: "+collision.gameObject.name);
	}

	private void OnCollisionStay(Collision collision)
	{
		print("stay: "+collision.gameObject.name);
	}

	private void OnCollisionExit(Collision collision)
	{
		print("exit: "+collision.gameObject.name);
	}
}
