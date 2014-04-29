using UnityEngine;
using System.Collections;

public class DetectObject : MonoBehaviour {
	public GameObject OtherObject;
	public GameObject Sphere;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Physics.Raycast(OtherObject.transform.position,transform.position)){
			Instantiate(Sphere,OtherObject.transform.position,transform.rotation);		
	
		}
}
}