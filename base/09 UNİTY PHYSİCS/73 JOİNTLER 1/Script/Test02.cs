using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		print("enter");
	}

	private void OnCollisionStay2D(Collision2D collision)
	{
		print("stay");
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		print("exit");
	}
}
