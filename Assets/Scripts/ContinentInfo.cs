using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ContinentInfo : MonoBehaviour {
	
	public string name;
	public int lives;
	public float health;

	public static ContinentInfo CreateFromJSON(string jsonString)
	{
		return JsonUtility.FromJson<ContinentInfo>(jsonString);
	}

		// Given JSON input:
		// {"name":"Dr Charles","lives":3,"health":0.8}
		// this example will return a PlayerInfo object with
		// name == "Dr Charles", lives == 3, and health == 0.8f.
	}