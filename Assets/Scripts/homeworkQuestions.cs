using UnityEngine;
using System.Collections;

public class homeworkQuestions : MonoBehaviour {
	//make a variable to reference a camera
	public Camera Cam1;
	public Camera Cam2;
	
	//public Camera cam1, cam2, etc.;
	//this is a faster way of doing the same thing
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > 3f){
			Cam1.enabled = false; 
			Cam2.enabled = true; 
			//switch from cam1 to cam2 at a certain time
		}
		Debug.Log (Time.time); //display time as it runs in console
	}
}
