using UnityEngine;
using System.Collections;



public class MainScript : MonoBehaviour {

	public float velocity;
	public GameObject enemyFab;

	public float x;
	public float y;
	public float z;
	
	// Use this for initialization
	void Start () {
		y = 0.1f;
		velocity = 0.3f;
	}

	
	
	// Update is called once per frame
	void Update () {
		spawnEnemy ();
		
	}
	//every second spawns a new soldier
	float timer=1;

	

	void spawnEnemy(){
		timer -= Time.deltaTime;
		if (timer<=0){
			timer=3;
			int rand = Random.Range(1,4);
			//Debug.Log("Soldier Spawn in position "+rand);
			if(rand==1){
				GameObject newEnemy = (GameObject) Instantiate(enemyFab, new Vector3(-1.5f,y,-6f), transform.rotation);
				newEnemy.rigidbody.velocity = new Vector3(0,0,velocity);
			}
			if(rand==2){
				GameObject newEnemy = (GameObject) Instantiate(enemyFab, new Vector3(6f,y,-1.5f), transform.rotation);
				newEnemy.rigidbody.velocity = new Vector3(-velocity,0,0);
			}
			if(rand==3){
				GameObject newEnemy = (GameObject) Instantiate(enemyFab, new Vector3(1.5f,y,6f), transform.rotation);
				newEnemy.rigidbody.velocity = new Vector3(0,0,-velocity);
			}
			if(rand==4){
				GameObject newEnemy = (GameObject) Instantiate(enemyFab, new Vector3(-6f,y,1.5f), transform.rotation);
				newEnemy.rigidbody.velocity = new Vector3(velocity,0,0);
			}
		}
	}
}
