using UnityEngine;
using System.Collections;

public class RotateRegions : MonoBehaviour {

	private Vector3 startRotation = new Vector3 (0f, 0f, 0f);
	private Vector3 endRotation = new Vector3 (0f, 360f, 0f);
	private float smoothFactor = 0.2f;

	void Start () {

		//GameObject scriptContainer = GameObject.Find("ScriptContainer"); 

		//a_NorthAmerica.northAmericaParent.transform.localRotation = new Vector3 (0f, 0f, 0f);
	}

	void Update () {
		
		//a_NorthAmerica.northAmericaParent.transform.eulerAngles = Vector3.Lerp (startRotation, endRotation, Time.deltaTime * smoothFactor + 0.2f);

	}
}
