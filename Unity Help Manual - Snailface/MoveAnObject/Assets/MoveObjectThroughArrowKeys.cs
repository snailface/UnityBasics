using UnityEngine;
using System.Collections;

public class MoveObjectThroughArrowKeys : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)){
			transform.position = Vector3.Lerp(transform.position,transform.TransformPoint(Vector3.forward),10f*Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			transform.position = Vector3.Lerp(transform.position,transform.TransformPoint(Vector3.back),10f*Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			transform.position = Vector3.Lerp(transform.position,transform.TransformPoint(Vector3.left),10f*Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			transform.position = Vector3.Lerp(transform.position,transform.TransformPoint(Vector3.right),10f*Time.deltaTime);
		}
	}
}
