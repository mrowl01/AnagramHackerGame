	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Terminal.WriteLine ("What would you like to hack into?"); 
		Terminal.WriteLine ("Enter 1 : Library"); 
		Terminal.WriteLine ("Enter 2 : Police Station"); 
		Terminal.WriteLine ("Enter your selection:"); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
