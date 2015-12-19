/*
	Script File:		GameOverController.cs
	Author:				Khandker Faim Hussain
	Date Modified:		12/15/2015
	Description:		Game over scene with texts and a button to go back to start menu
	Revision History:	...
*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour 
{
	//PUBLIC INSTANCE VAIRABLES
	public Button playAgainText;

	// Use this for initialization
	void Start () 
	{
		playAgainText = playAgainText.GetComponent<Button> ();
	}

	//METHODS - TRANSITIONING BETWEEN SCENES
	public void PlayAgain()
	{
		Application.LoadLevel ("StartMenu");
	}
}
