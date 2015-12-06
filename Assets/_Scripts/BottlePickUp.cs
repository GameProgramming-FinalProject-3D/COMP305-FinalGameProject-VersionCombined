<<<<<<< HEAD
﻿/*
	Script File:		BottlePickUp.cs
	Author:				Shruti Kirti Kaushal
	Date Modified:		12/05/2015
	Description:		...
	Revision History:	...
*/
using UnityEngine;
=======
﻿using UnityEngine;
>>>>>>> origin/master
using System.Collections;
using UnityEngine.UI;

public class BottlePickUp : MonoBehaviour {

    // private GameObject _player;
    public Text scoreLabel;



    private int _scoreValue;
    //Public Properties
    public int Score
    {
        get
        {
            return this._scoreValue;
        }
        set
        {
            this._scoreValue = value;
            this._updateScoreBoard();
        }
    }
    // Add score to _scoreValue Instance Variable
    public void AddScore(int value)
    {
        this._scoreValue += value;
        this._updateScoreBoard();
    }

    // Use this for initialization
    void Start () {
        this._scoreValue = 0;
        this._updateScoreBoard();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
<<<<<<< HEAD
            AddScore(10);
=======
            AddScore(100);
>>>>>>> origin/master
        }
    }
       private void _updateScoreBoard()
    {
        this.scoreLabel.text = "Score: " + this._scoreValue;
       
    }
}

