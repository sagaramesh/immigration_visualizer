using UnityEngine;
using System.Collections;

public class ActivateRegions : MonoBehaviour {

	public GameObject regionsPanel;

    private BoxCollider childColliders;
	private Vector3 regionsFinalPosition = new Vector3 (1.306f, 1.048f, -0.017f);
	//private Vector3 regionsFinalScale = new Vector3 (1f, 1f, 1f);
	private float smoothFactor = 2f;

	void Start () {

		transform.localPosition = new Vector3 (7.0f, 1.048f, -0.017f);
		//transform.localScale = new Vector3 (0f, 0f, 0f);
	}

	void Update () {

		transform.localPosition = Vector3.Lerp (transform.localPosition, regionsFinalPosition, Time.deltaTime * smoothFactor + 0.2f);
		//transform.localScale = Vector3.Lerp (transform.localScale, regionsFinalScale, Time.deltaTime * smoothFactor + 0.2f);

	}

    // TODO: Figure out a way to disbale box colliders before regionsFinalPosition
}
