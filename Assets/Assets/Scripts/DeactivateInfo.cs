using UnityEngine;
using System.Collections;

public class DeactivateInfo : MonoBehaviour {

	public GameObject infoMessage;
	private Vector3 infoMessageScaleDown = new Vector3 (0f, 0f, 0f);
	private float smoothFactor = 2f;

	void Start () {
		transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
	}

	void Update () {

		transform.localScale = Vector3.Lerp (transform.localScale, infoMessageScaleDown, Time.deltaTime * smoothFactor + 0.2f);

	}
}
