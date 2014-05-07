using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {

	public int Distance = 5;
	// Use this for initialization
	void Start () {
		Screen.showCursor = false; // Hides the Cursor
	}
	
	// Update is called once per frame
	void Update () {
		//Casts a ray from the cursor location to screen space  and in turn to world space
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
		//Gets a 3D Cordinate for a point on the ray 
		Vector3 position = ray.GetPoint(Distance);
		//Transform the Object along the Vector3 Cordinates
		transform.position = position;
	}
}