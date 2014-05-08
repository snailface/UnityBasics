using UnityEngine;
using System.Collections;

public class MoveandFreezeCubes : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			Time.timeScale = 0;
		} 

		if(Input.GetKeyDown(KeyCode.Return)){
			Time.timeScale = 1;
		} 
		}

	void FixedUpdate(){
		transform.Rotate(Vector3.up);

	}
	
}