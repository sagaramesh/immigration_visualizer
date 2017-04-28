using UnityEngine;
using System.Collections;

public class ActivateMap : MonoBehaviour {

	public GameObject map;
	private Vector3 mapFinalScale = new Vector3 (0.13f, 0.13f, 0.13f);
	private float smoothFactor = 2f;

	void Start () {
		transform.localScale = new Vector3 (0f, 0f, 0f);
	}

	void Update () {
		transform.localScale = Vector3.Lerp (transform.localScale, mapFinalScale, Time.deltaTime * smoothFactor + 0.2f);

	}
}
