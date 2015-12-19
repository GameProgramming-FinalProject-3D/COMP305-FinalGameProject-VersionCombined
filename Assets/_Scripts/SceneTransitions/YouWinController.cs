using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class YouWinController : MonoBehaviour 
{
	//PUBLIC INSTANCE VAIRABLES
	public Button backToMenu;
	
	// Use this for initialization
	void Start () 
	{
		backToMenu = backToMenu.GetComponent<Button> ();
	}
	
	//METHODS - TRANSITIONING BETWEEN SCENES
	public void Menu()
	{
		Application.LoadLevel ("StartMenu");
	}
}
