/*
	Script File:		StartMenuController.cs
	Author:				Khandker Faim Hussain
	Date Modified:		12/15/2015
	Description:		Buttons, text, and scene transitioning from StartMenu scene
	Revision History:	...
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartMenuController : MonoBehaviour 
{
	//PUBLIC INSTANCE VAIRABLES
	public Button startText;
	public Button instructionText;
	public Button exitText;

	// Use this for initialization
	void Start () 
	{
		startText = startText.GetComponent<Button>();
		instructionText = instructionText.GetComponent<Button>();
		exitText = exitText.GetComponent<Button> ();
	}

	//
//	public void ExitPressed()
//	{
//		quitMenu.enabled = true;
//		startText.enabled = false;
//		exitText.enabled = false;
//	}

	//METHODS - TRANSITIONING BETWEEN SCENES
	public void StartLevel()
	{
		Application.LoadLevel ("Level01"); //the index number refers to the build settings
	}

	public void InstructionsScene()
	{
		Application.LoadLevel ("Instructions"); //the index number refers to the build settings
	}

	public void ExitGame()
	{
		Application.Quit ();
	}
}