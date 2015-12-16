using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour 
{	
	//COLLISION METHODS
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			Application.LoadLevel("Level02");
		}
	}
}
