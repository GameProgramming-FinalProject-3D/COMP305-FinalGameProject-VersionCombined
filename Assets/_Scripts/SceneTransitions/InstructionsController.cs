/*
	Script File:		InstructionsController.cs
	Author:				Khandker Faim Hussain
	Date Modified:		12/15/2015
	Description:		Scene with instructions and controls for the game
	Revision History:	...
*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InstructionsController : MonoBehaviour 
{
	//PUBLIC INSTANCE VAIRABLES
	public Button backToStartText;

	// Use this for initialization
	void Start () 
	{
		backToStartText = backToStartText.GetComponent<Button> ();
	}
	
	//METHODS - TRANSITIONING BETWEEN SCENES
	public void BackToStart()
	{
		Application.LoadLevel (0); //the index number refers to the build settings
	}
}