using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

public class ActivateExperience : MonoBehaviour {

	public NVRButton Button;

	public GameObject intro_message;

	public GameObject ok_label;
	public GameObject ok_label_bottom;

	public GameObject world_map;

	public GameObject ok_button;
	public GameObject yearsPanel;
	public GameObject regionsPanel;
	public GameObject infoButton;

	public GameObject sphere;

	void Start () {

		yearsPanel.GetComponent<ActivateYears> ().enabled = false;
		regionsPanel.GetComponent<ActivateRegions> ().enabled = false;
		infoButton.GetComponent<ActivateInfo> ().enabled = false;
		world_map.GetComponent<ActivateMap> ().enabled = false;
		
	}

	void Update () {

		if (Button.ButtonDown || Input.GetKeyDown (KeyCode.S)) {

			yearsPanel.GetComponent<ActivateYears> ().enabled = true;
			regionsPanel.GetComponent<ActivateRegions> ().enabled = true;
			infoButton.GetComponent<ActivateInfo> ().enabled = true;
			world_map.GetComponent<ActivateMap> ().enabled = true;

			StartCoroutine (IntroFadeOut(0.0f, 1.0f));
			StartCoroutine (OKButtonFade(0.0f, 1.0f));
			StartCoroutine (OKBottomFade(0.0f, 1.0f));

			StartCoroutine ("DeactivateIntro");
		}
		
	}

	IEnumerator IntroFadeOut(float intro_aValue, float intro_aTime)
	{
		float intro_alpha = intro_message.GetComponent<SpriteRenderer>().material.color.a; 

		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / intro_aTime) {
			Color newColor = new Color (1, 1, 1, Mathf.Lerp (intro_alpha, intro_aValue, t));
			intro_message.GetComponent<SpriteRenderer> ().material.color = newColor;

			yield return new WaitForEndOfFrame();
		}
	}

	IEnumerator OKButtonFade(float ok_aValue, float ok_aTime)
	{
		float ok_alpha = ok_label.GetComponent<SpriteRenderer>().material.color.a; 

		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / ok_aTime) {
			Color newColor = new Color (1, 1, 1, Mathf.Lerp (ok_alpha, ok_aValue, t));
			ok_label.GetComponent<SpriteRenderer> ().material.color = newColor;

			yield return new WaitForEndOfFrame();
		}
	}

	IEnumerator OKBottomFade(float okbottom_aValue, float okbottom_aTime)
	{
		float okbottom_alpha = ok_label_bottom.GetComponent<SpriteRenderer>().material.color.a; 

		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / okbottom_aTime) {
			Color newColor = new Color (1, 1, 1, Mathf.Lerp (okbottom_alpha, okbottom_aValue, t));
			ok_label_bottom.GetComponent<SpriteRenderer> ().material.color = newColor;

			yield return new WaitForEndOfFrame();
		}
	}

	IEnumerator DeactivateIntro(){

		yield return new WaitForSeconds(1);
		intro_message.SetActive(false);
		ok_button.SetActive (false);

		yield return new WaitForEndOfFrame ();
	}
}
