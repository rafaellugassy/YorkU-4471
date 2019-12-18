using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	string state = "";
	GameObject[] obj;
	Light[] light;
	int objIterator, lightIterator;
	Renderer r;
	// Use this for initialization
	void Start () {
		objIterator = 0;
		lightIterator = 0;
		light = Light.FindObjectsOfType<Light> ();
		obj = GameObject.FindGameObjectsWithTag ("object");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.I))
			state = "move";
		else if (Input.GetKeyDown (KeyCode.R))
			state = "rotate";
		else if (Input.GetKeyDown (KeyCode.S)) {
			if (state == "object")
				objIterator = (objIterator + 1) % obj.Length;
			state = "object";
		}
		else if (Input.GetKeyDown(KeyCode.L)){
			if (state == "light")
				lightIterator = (lightIterator + 1) % light.Length;
			state = "light";
		}
		
		if (Input.GetKey(KeyCode.A)) {
			if (state == "move")
				transform.position -= transform.right;
			else if (state == "rotate")
				transform.RotateAround (transform.position, transform.up, -1);
			else if (state == "object")
				obj [objIterator].transform.RotateAround (obj[objIterator].transform.position, obj[objIterator].transform.up, -1);
			else if (state == "light")
				light [lightIterator].intensity -= 0.1f;
				
		} else if (Input.GetKey(KeyCode.D)) {
			if (state == "move") 
				transform.position += transform.right;
			else if (state == "rotate") 
				transform.RotateAround (transform.position, transform.up, 1);
			else if (state == "object")
				obj [objIterator].transform.RotateAround (obj[objIterator].transform.position, obj[objIterator].transform.up, 1);
			else if (state == "light")
				light [lightIterator].intensity += 0.1f;

		} else if (Input.GetKey(KeyCode.X)) {
			if (state == "move") 
				transform.position -= transform.forward;
			else if (state == "rotate") 
				transform.RotateAround (transform.position, transform.right, 1);
			else if (state == "object")
				obj [objIterator].transform.RotateAround (obj[objIterator].transform.position, obj[objIterator].transform.right, 1);
			

		} else if (Input.GetKey(KeyCode.W)) {
			if (state == "move") 
				transform.position += transform.forward;
			else if (state == "rotate") 
				transform.RotateAround (transform.position, transform.right, -1);
			else if (state == "object")
				obj [objIterator].transform.RotateAround (obj[objIterator].transform.position, obj[objIterator].transform.right, -1);
			
		}
	}
}
