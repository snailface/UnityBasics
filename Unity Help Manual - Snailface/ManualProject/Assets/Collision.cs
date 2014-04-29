using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.name == "New Cube"){
			Debug.Log("Congratulations!!! Collision Successful");
		}
	}
}