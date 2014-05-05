using UnityEngine;
using System.Collections;

public class AsterixBehavour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "Obelix") {
			Debug.Log("Asterix bumped Obelix");		
		}
	}
}
