using UnityEngine;
using System.Collections;

public class MoveSphere : MonoBehaviour {
	private GameObject FindCapsule;
	// Use this for initialization
	void Start () {
		FindCapsule = GameObject.Find("Capsule");
	}
	
	// Update is called once per frame
	void Update () {
		if(FindCapsule.transform.position.x > FindCapsule.transform.position.z){
	transform.Translate(0f,0f,-1f);
	}
		if(FindCapsule.transform.position.x < FindCapsule.transform.position.z){
			transform.Translate(0f,0f,1f);
		}

		Destroy(gameObject,0.2f);
	}
}