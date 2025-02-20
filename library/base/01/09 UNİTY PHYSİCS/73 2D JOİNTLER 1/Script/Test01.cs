using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
	private void OnTriggerEnter2D(Collision2D collision)
	{
		print("enter");
	}

	private void OnTriggerStay2D(Collision2D collision)
	{
		print("stay");
	}

	private void OnTriggerExit2D(Collision2D collision)
	{
		print("exit");
	}
}
