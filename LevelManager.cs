﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {


	public static int brickCount;


	void Start(){

	}


	public void LevelLoad (string lvl) {
		SceneManager.LoadScene (lvl);
	}
		
	public void ExitGame (){ //don't have this funtion with a mobile build
		print ("Tried to exit.");
		Application.Quit ();
	}

	public void LoadNextLevel (){
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}
		
}
	
