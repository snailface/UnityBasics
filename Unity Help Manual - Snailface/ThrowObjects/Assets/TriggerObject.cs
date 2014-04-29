using UnityEngine;
using System.Collections;

public class TriggerObject : MonoBehaviour {
	public GameObject Capsule;
	public GameObject EmptyGameObjectTrigger;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.Space)){
			Instantiate(Capsule,EmptyGameObjectTrigger.transform.position,EmptyGameObjectTrigger.transform.rotation);
		}

	}
}	
