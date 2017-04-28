using UnityEngine;
using System.Collections;

public class ActivateInfo : MonoBehaviour {

	public GameObject infoPanel;
	private Vector3 infoFinalPosition = new Vector3 (0f, 1.0494f, -1.47f);
	private Vector3 infoFinalScale = new Vector3 (0.12f, 0.12f, 0.12f);
	private float smoothFactor = 2f;

	void Start () {

		transform.localPosition = new Vector3 (0f, 1.0494f, -7f);
		transform.localScale = new Vector3 (0f, 0f, 0f);
	}

	void Update () {

		transform.localPosition = Vector3.Lerp (transform.localPosition, infoFinalPosition, Time.deltaTime * smoothFactor + 0.2f);
		transform.localScale = Vector3.Lerp (transform.localScale, infoFinalScale, Time.deltaTime * smoothFactor + 0.2f);

	}
}
