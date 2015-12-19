using UnityEngine;
using System.Collections;

public class TransitionToWinScreenController : MonoBehaviour 
{
	//COLLISION METHODS
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			Application.LoadLevel("YouWin");
		}
	}
}
