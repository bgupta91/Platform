using UnityEngine;
using System.Collections;

/*
 * This script is just being used to test the follow script.
 * */
public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		var position = transform.position;
		position.x += 0.1F;
		transform.position = position;
		
		/*
		if (Input.GetKey(KeyCode.UpArrow)) {
			if (transform.rotation.z < 0.3) {
				transform.Rotate (Vector3.forward * rotationSpeed * Time. deltaTime);
			}
		}*/
	}
}
