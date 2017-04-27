using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSphere : MonoBehaviour {

	float lerpTime = 1f;
	float currentLerpTime;

	public Renderer reverseSphere;

	public Color32 startColor = Color.white;
	public Color32 endColor = Color.black;
	public Color32 lerpedColor;

	void Update() {

		//Color tempColor = reverseSphere.GetComponent<Renderer> ().material.color;
		//tempColor.a = Mathf.MoveTowards(0, 1, Time.deltaTime);
		//reverseSphere.GetComponent<Renderer> ().material.color = tempColor;

		currentLerpTime += Time.deltaTime;
		if (currentLerpTime > lerpTime) {
			currentLerpTime = lerpTime;
		}

		float percentage = currentLerpTime / lerpTime;
		lerpedColor = Color32.Lerp(startColor, endColor, percentage);
	}
}
