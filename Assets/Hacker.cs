	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	string greeting = "Hey Hacka";
	// Use this for initialization
	void Start () {
		ShowMainMenu (); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ShowMainMenu()
	{
		Terminal.ClearScreen (); 
		Terminal.WriteLine ("What would you like to hack into?"); 
		Terminal.WriteLine ("Enter 1 : Library"); 
		Terminal.WriteLine ("Enter 2 : Police Station"); 
		Terminal.WriteLine ("Enter your selection:"); 
	}
}
