using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_GenerateAfrica : MonoBehaviour {

	// Need to take data points, divide by 10,000

	public GameObject continent_group;
	public int numberOfObjects = 10;
	public float radius = 5f;

	// Use this for initialization

	void Start () {
		StartCoroutine ("delayCall");

	}

	IEnumerator  delayCall () {

		for (int i = 0; i < numberOfObjects; i++) {
			Vector3 position = Random.onUnitSphere * 2.8f; // Change this value depending on how large the unit circle should be
			Instantiate (continent_group, position, Quaternion.identity);
			yield return new WaitForSeconds (0.03f);
		}

		if (numberOfObjects == numberOfObjects) {
			print ("Africa complete " + Time.time);
		}
	}
}

// Opacity shifts. Note: Changes in opacity do not work well because objects and instantiated too quickly:

//Color objectColor = continent_group.GetComponent<Renderer> ().sharedMaterial.color; 
//Color objectEmission = continent_group.GetComponent<Renderer> ().sharedMaterial.GetColor ("_EmissionColor"); 

//continent_group.GetComponent<Renderer> ().sharedMaterial.color = Color.Lerp (Color.black, Color.white, 0.5f);
//continent_group.GetComponent<Renderer> ().sharedMaterial.SetColor ("_EmissionColor", Color.Lerp (Color.black, Color.white, 0.5f)); 

