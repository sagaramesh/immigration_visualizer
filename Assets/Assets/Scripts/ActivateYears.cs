using UnityEngine;
using System.Collections;

public class ActivateYears : MonoBehaviour {

	public GameObject yearsPanel;
	private Vector3 yearsFinalPosition = new Vector3 (-1.26f, 1.0142f, 0.0016f);
	private Vector3 yearsFinalScale = new Vector3 (1f, 1f, 1f);
	private float smoothFactor = 2f;

	void Start () {

		transform.localPosition = new Vector3 (-7.0f, 1.0142f, 0.0016f);
		transform.localScale = new Vector3 (0f, 0f, 0f);
	}

	void Update () {

		transform.localPosition = Vector3.Lerp (transform.localPosition, yearsFinalPosition, Time.deltaTime * smoothFactor + 0.2f);
		transform.localScale = Vector3.Lerp (transform.localScale, yearsFinalScale, Time.deltaTime * smoothFactor + 0.2f);

	}
}
