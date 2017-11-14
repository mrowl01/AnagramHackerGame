	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
	int level;
	// Use this for initialization
	void Start () {
		
		ShowMainMenu ("Hello Hacka"); 

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ShowMainMenu(string greeting)
	{
		Terminal.ClearScreen (); 
		Terminal.WriteLine (greeting); 
		Terminal.WriteLine ("What would you like to hack into?"); 
		Terminal.WriteLine ("Enter 1 : Library"); 
		Terminal.WriteLine ("Enter 2 : Police Station"); 
		Terminal.WriteLine ("Enter your selection:"); 
	}
	void OnUserInput (string theInput)
	{
		if (theInput == "1" || theInput == "2" || theInput == "3") {
			int tempInt;
			tempInt= int.Parse (theInput);
			level = tempInt; 
			StartGame ();

		} else if (theInput == "007") {
			Terminal.WriteLine ("Hello, Mr.Bond");
		} else if (theInput == "menu") {
			ShowMainMenu ("Hello Hacker"); 
		}
		else {
			Terminal.WriteLine ("Not a valid option"); 
		}
	}
	void StartGame ( )
	{
		Terminal.WriteLine ("You have choesen level " + level); 
	}


}
