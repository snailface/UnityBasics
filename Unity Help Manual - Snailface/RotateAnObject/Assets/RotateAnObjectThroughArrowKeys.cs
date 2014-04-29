using UnityEngine;
using System.Collections;

public class RotateAnObjectThroughArrowKeys : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)){
			//transform.Rotate(Vector3.left);
			transform.Rotate(5f,0,0);
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			//transform.Rotate(Vector3.right);
			transform.Rotate(-5f,0,0);
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate(0,5f,0);
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate(0,-5f,0);
		}
	}
}
