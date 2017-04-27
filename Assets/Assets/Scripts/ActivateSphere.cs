using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

public class ActivateSphere : MonoBehaviour {
	
	public NVRButton Button;

	public GameObject sphere;
	public GameObject info_message;

	public GameObject info_label;
	public GameObject exit_label;

	float infolabelnumber;
	float exitlabelnumber;

	// 1 is active, 2 is inactive 

	//private float sphereDuration = 1f;

	void Start(){
		info_message.SetActive (false);

		infolabelnumber = 1;
		exitlabelnumber = 2;
	}

	void Update() {

		// INFO AND EXIT LABEL CONDITIONS

		if (infolabelnumber == 1) {
			info_label.SetActive (true);
		} else if (infolabelnumber == 2) {
			info_label.SetActive (false);
		} else {
			info_label.SetActive (false);
		}
		if (exitlabelnumber == 1) {
			exit_label.SetActive (true);
		} else if (exitlabelnumber == 2) {
			exit_label.SetActive (false);
		} else {
			exit_label.SetActive (false);
		}

		// BUTTON CONDITIONS

		if(Button.ButtonDown && infolabelnumber == 1 || Input.GetKeyDown(KeyCode.T)) // Info and Sphere at full opacity  
		{
			StartCoroutine(InfoFader(1.0f, 1.0f));
			StartCoroutine(SphereFader(1.0f, 1.0f));

			infolabelnumber = 2;
			exitlabelnumber = 1;
		}
		if(Button.ButtonDown && exitlabelnumber == 1 || Input.GetKeyDown(KeyCode.F)) // Info and sphere at zero opacity
		{
			StartCoroutine(InfoFader(0.0f, 1.0f));
			StartCoroutine(SphereFader(0.0f, 1.0f));

			infolabelnumber = 1;
			exitlabelnumber = 2;
		}
	}

	IEnumerator SphereFader(float sphere_aValue, float sphere_aTime)
	{
		float sphere_alpha = sphere.GetComponent<Renderer>().material.color.a; 

		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / sphere_aTime) {
			Color newColor = new Color (1, 1, 1, Mathf.Lerp (sphere_alpha, sphere_aValue, t));
			sphere.GetComponent<Renderer> ().material.color = newColor;

			yield return new WaitForEndOfFrame ();
		}
	}

	IEnumerator InfoFader(float info_aValue, float info_aTime)
	{
		info_message.SetActive (true);

		float info_alpha = info_message.GetComponent<SpriteRenderer>().material.color.a; 

		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / info_aTime)
		{
			Color newColor = new Color(1, 1, 1, Mathf.Lerp(info_alpha,info_aValue,t));
			info_message.GetComponent<SpriteRenderer>().material.color = newColor;

			yield return new WaitForEndOfFrame ();
		}
	}

}
