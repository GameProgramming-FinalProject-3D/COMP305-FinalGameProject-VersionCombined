/*
	Script File:		PlayerHealth.cs
	Author:				Khandker Faim Hussain
	Date Modified:		Thurs 12/10/2015
	Description:		Code from "Survival Shooter" and Assignment 03
	Revision History:	IDK!!!...
*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    //PUBLIC INSTANCE VARIABLES (ACCESSIBLE IN UNITY)
	public int startingHealth = 100; //the amount of health the player starts the game with.
	public int currentHealth; //the current health the player has.
	public Slider healthSlider; // reference to the UI's health bar.
	public Image damageImage; //reference to an image to flash on the screen on being hurt.
//	public AudioClip deathClip; //the audio clip to play when the player dies.
	public float flashSpeed = 5f; //the speed the damageImage will fade at.
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f); // the colour the damageImage is set to, to flash. RED!
   
//	public int score; //NOTE: static = belongs to the class and not an instance of the class

	//PRIVATE INSTANCE VARIABLES
	Text _scoreText;
	private int _score;
	private AudioSource[] _audioSources; //array of audio sources
	private AudioSource _hurtSound; //reference to the AudioSource component.
	private AudioSource _count;


	//REFERENCES
    private Animator _anim; //reference to the Animator component.
//	private Player _playerMovement; //reference to the player's movement.
//	private PlayerShooting _playerShooting; //reference to the PlayerShooting script.
//	private bool _isDead; //whether the player is dead.
	private bool _damaged; // true when the player gets damaged.

 
    //METHODS (OFTEN USED)
    void Awake ()
	{
		// Setting up the references.
		_anim = GetComponent <Animator> ();
		_hurtSound = GetComponent <AudioSource> ();
       // this._count = GetComponent<AudioSource>();
//		_playerMovement = GetComponent <Player> ();
//		_playerShooting = GetComponentInChildren <PlayerShooting> (); //referencing to the child of Player: "gun barrel".
		
		// Set the starting health of the player.
		currentHealth = startingHealth;

		//Score stuff and score set to 0
		_scoreText = GetComponent <Text> (); //component reference
//		score = 0; //resets score to 0
	}

	void Update ()
	{
		//Creating score text with concatenation
//		_scoreText.text = "Score: " + score; //basic concatenation for the text variable to set the string and it's int value

		// If the player has just been damaged
		if(_damaged)
		{
			//then set the colour of the damageImage to the flash colour.
			damageImage.color = flashColour;
		}
		// Otherwise...
		else
		{
			// otherwise the of the transition the colour back to clear.
			//note: Color.Lerp() is when you assign three values and the values are interpolated between the three values (colors)
			//ie. Color.Lerp(image color for damage, clear "screen" color, and flash speed)
			damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		
		// Resets the damaged flag
		_damaged = false;
	}
	
	//PUBLIC METHODS
	//this method is called by other scripts in Unity. (must be public, or won't work)
//    public void PickBottle(int amount)
//    {
//        this._count.Play();
//    }

	public void TakeDamage (int amount)
	{
		// Set the damaged flag so the screen will flash
		_damaged = true;
		
		// Reduce the current health by the damage amount (decrements)
		currentHealth -= amount;
		
		healthSlider.value = currentHealth;// Set the health bar's value to the current health.
		
		_hurtSound.Play ();// Play the hurt sound effect.
		
//		// straightforward...health equals or below to 0, then call Death()
		if(currentHealth <= 0)
		{
			// Player dies
			Death ();

//			Application.LoadLevel("GameOver");
		}
	}
	
	//Method for being dead
	void Death ()
	{
		//Calls "GameOver" scene
		Application.LoadLevel("GameOver");

//		//Carry out the final score from player
//
//
//		// Set the death flag so this function won't be called again.
//		_isDead = true;
//
//		// Set the audiosource to play the death clip and play it (this will stop the hurt sound from playing).
//		_hurtSound.Play ();
//		
//		// Turn off the movement and shooting scripts.
//		_playerMovement.enabled = false; //stops player movement script
//		_playerShooting.enabled = false;//stops player shooting script
	}       
}