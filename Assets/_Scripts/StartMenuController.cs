/*
	Script File:		StartMenuController.cs
	Author:				Khandker Faim Hussain
	Date Modified:		...
	Description:		...
	Revision History:	...
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartMenuController : MonoBehaviour 
{
	//PUBLIC INSTANCE VAIRABLES
	public Canvas quitMenu;
	public Button startText;
	public Button exitText;

	// Use this for initialization
	void Start () 
	{
		quitMenu = quitMenu.GetComponent<Canvas>();
		startText = startText.GetComponent<Button>();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;

	}
	
	public void ExitPressed()
	{
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	}

//	public void NoPress()
//	{
//		quitMenu.enabled = false;
//		startText.enabled = false;
//		exitText.enabled = true;
//	}

	public void StartLevel()
	{
		Application.LoadLevel (1); //Scene name
	}

	public void ExitGame()
	{
		Application.Quit ();
	}
}