/*
	Script File:		ItemController.cs
	Author:				Khandker Faim Hussain
	Date Modified:		Thurs 12/10/2015
	Description:		Code from "Survival Shooter" and Assignment 03
	Revision History:	IDK!!!...
*/
using UnityEngine;
using System.Collections;

public class ItemController : MonoBehaviour
{
	//PUBLIC INSTANCE VARIABLES
	//	public int scoreValue = 10;
	
	//COLLISION METHODS
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			Destroy(gameObject); //destroys the item game object
//			PlayerScore.score += scoreValue; //adds score to scoreText
		}
	}
}