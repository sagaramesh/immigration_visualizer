using UnityEngine;
using System.Collections;

public class ActivateInfoButton : MonoBehaviour {

	public GameObject infoButton;
	private Vector3 infoButtonFinalPosition = new Vector3 (0f, 1.0494f, -1.47f);
	private Vector3 infoButtonFinalScale = new Vector3 (0.12f, 0.12f, 0.12f);
	private float smoothFactor = 2f;

	void Start () {

		transform.localPosition = new Vector3 (0f, 1.0494f, -7f);
		transform.localScale = new Vector3 (0f, 0f, 0f);
	}

	void Update () {

		transform.localPosition = Vector3.Lerp (transform.localPosition, infoButtonFinalPosition, Time.deltaTime * smoothFactor + 0.2f);
		transform.localScale = Vector3.Lerp (transform.localScale, infoButtonFinalScale, Time.deltaTime * smoothFactor + 0.2f);

	}
}
