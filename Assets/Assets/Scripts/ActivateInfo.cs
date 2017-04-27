using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

public class ActivateInfo : MonoBehaviour {

	public NVRButton Button;
	public GameObject reverseSphere;
	public Color fadecolor;

	// Use this for initialization
	void Start () {
	}
	void Update () {

		fadecolor = reverseSphere.GetComponent<Renderer> ().material.color; 

		if (Button.ButtonDown || Input.GetKeyDown (KeyCode.A)) {

			fadecolor = Color.Lerp (Color.black, Color.white, Time.time);
			print ("color switch");
		} 
		else {

			print ("nothing happening fam");
		}
	}	
}