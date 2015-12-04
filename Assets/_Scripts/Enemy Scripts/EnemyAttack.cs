﻿/*
	Script File:		EnemyAttackt.cs
	Author:				Khandker Faim Hussain
	Date Modified:		12/03/2015
	Description:		Code created from "Survival Shooter" Tutorial
	Revision History:	IDK!!!...
*/
using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour 
{
	//PUBLIC INSTANCE VARIABLES
	public float attackRate = 0.5f;
	public int attackDamage = 10;
	
	//PRIVATE INSTANCE VARIABLES 
	//(REFERENCES)
	private Animator _anim;
	private GameObject _player;
	private PlayerHealth _playerHealth;
//	private EnemyHealth _enemyHealth;
	
	private bool _playerInRange;
	private float _timer; //
	
	//SET UP
	void Awake ()
	{
		_player = GameObject.FindGameObjectWithTag ("Player"); 
		_playerHealth = _player.GetComponent <PlayerHealth> ();//script reference
//		_enemyHealth = GetComponent<EnemyHealth>();//script reference
		_anim = GetComponent <Animator> ();
	}
	
	//TRIGGER METHODS
	//Ensuring player is near, if yes then attack
	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject == _player)
		{
			_playerInRange = true;//player's near
		}
	}
	
	//If player is gone, then stop attacking
	void OnTriggerExit (Collider other)
	{
		if(other.gameObject == _player)
		{
			_playerInRange = false; //player's gone
		}
	}
	
	//
	void Update ()
	{
		_timer += Time.deltaTime;
		
		//note (in parameters): if(time to attack AND player's in range AND enemy's health is > 0, then attack!
		if(_timer >= attackRate && _playerInRange /*&& _enemyHealth.currentHealth > 0*/)
		{
			Attack ();
		}
		
//		if(_playerHealth.currentHealth <= 0)
//		{
//			_anim.SetTrigger ("PlayerDead");
//		}
	}
	
	//Actual attack function
	void Attack ()
	{
		_timer = 0f;//resets the time
		
		if(_playerHealth.currentHealth > 0)
		{
			_playerHealth.TakeDamage (attackDamage);
			_anim.SetTrigger ("EnemyAttack");
		}
	}
}