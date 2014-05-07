using UnityEngine;
using System.Collections;

public class Reinstate : MonoBehaviour {
	private Vector3 InitialPosition;
	// Use this for initialization
	void Start () {
		InitialPosition = transform.position; 
		rigidbody.isKinematic = true;
		rigidbody.useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){
			rigidbody.useGravity = true;
			rigidbody.isKinematic = false;
		}

		if(transform.position.y < 0.5){
			transform.position = InitialPosition;
			rigidbody.useGravity = false;
			rigidbody.isKinematic = true;
		}

	}
}
