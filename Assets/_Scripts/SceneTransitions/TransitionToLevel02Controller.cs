using UnityEngine;
using System.Collections;

public class TransitionToLevel02Controller : MonoBehaviour 
{	
	//COLLISION METHODS
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			Application.LoadLevel("GameOver");
		}
	}
}
