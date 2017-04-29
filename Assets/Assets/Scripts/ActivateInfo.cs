using UnityEngine;
using System.Collections;

public class ActivateInfo : MonoBehaviour {

	public GameObject infoMessage;
	private Vector3 infoMessageScaleUp = new Vector3 (0.1f, 0.1f, 0.1f);
	private float smoothFactor = 2f;

	void Start () {
		transform.localScale = new Vector3 (0f, 0f, 0f);
	}

	void Update () {
		
		transform.localScale = Vector3.Lerp (transform.localScale, infoMessageScaleUp, Time.deltaTime * smoothFactor + 0.2f);

	}
}
