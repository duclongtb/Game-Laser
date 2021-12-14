﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour {

	int score = 0;

	private void Awake()
    {
		SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        int numberGameSessions = FindObjectsOfType<GameSession>().Length;
		if(numberGameSessions>1)
        {
			Destroy(gameObject);
        }
		else
        {
			DontDestroyOnLoad(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public int GetScore()
    {
		return score;
    }

	public void AddToScore(int scoreValue)
    {
		score += scoreValue;
    }

	public void ResetGame()
    {
		Destroy(gameObject);
    }
}
