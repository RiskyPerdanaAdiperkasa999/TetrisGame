using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour{

	//Groups
	public GameObject[] groups ;
	public void spawnNext(){

			//Random Incex
	int a=Random.Range(0,groups.Length);

		//spawn Group at Current position
				 Instantiate (groups[a],
				 transform.position, //position spawn
				 Quaternion.identity); //Default rotattion

	}
	void Start(){

		//Spawn initial group

		spawnNext();
	}
}
