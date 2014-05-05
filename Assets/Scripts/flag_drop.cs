using UnityEngine;
using System.Collections;

public class flag_drop : MonoBehaviour {

	// Use this for initialization
	public GameObject flag;
	public float downRate = 0.01f;
	void Start () {
	



	}
	
	// Update is called once per frame
	void Update () {
	

	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name.ToLower().Contains("soldier")) {
			Debug.Log("Dropping the flag!");
			Vector3 xyz = flag.transform.position;

			if(xyz[1]-downRate<=0){
				Debug.Log("GAME OVER!");
			}
			else{
				flag.transform.position = new Vector3(xyz[0],xyz[1]-downRate,xyz[2]);
			}

		}
	}
}
