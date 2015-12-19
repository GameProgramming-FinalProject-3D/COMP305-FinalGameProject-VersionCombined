using UnityEngine;
using System.Collections;

public class TransitionToLevel03Controller : MonoBehaviour 
{
	//COLLISION METHODS
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			Application.LoadLevel("Level03");
		}
	}
}