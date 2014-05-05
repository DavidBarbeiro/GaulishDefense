using UnityEngine;
using System.Collections;

public class HPScript : MonoBehaviour {

	public float health=100;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () 
	{

		if (health <= 0) 
		{
			//animation.play(die)
			Destroy(this);
		}


	}

	void OnCollisionEnter(Collision col)
	{
		Debug.Log (col.gameObject.name);
		if (col.gameObject.name == "flag") {
			Destroy(this.gameObject);

		} else if (col.gameObject.name == "asterix") {
			//if(col.gameObject == ON ATTACK) health-=50;
			//if 							&& Potion) health -=100


		}


	}
}
