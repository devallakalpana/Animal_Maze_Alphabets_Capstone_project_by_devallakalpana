﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public static int ScoreValue = 0;
	Text Score;

	// Use this for initialization
	void Start () {

		Score = GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		Score.text = "You Have Collected " + ScoreValue + " Stars ";
		
	}
}
