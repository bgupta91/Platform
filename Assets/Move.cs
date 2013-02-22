using UnityEngine;
using System.Collections;

/*
 * This script is just being used to test the follow script.
 * */
public class Move : MonoBehaviour {
	
	private double delay = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		var position = transform.position;
		position.x += 0.1F;
		transform.position = position;
		
		
		if (Input.GetKey(KeyCode.Space) && delay <= 0) {
			transform.Translate(0,3.5f,0);
			delay = 40 * Time.deltaTime;
			
		}
			
		delay = delay - Time.deltaTime;
	}
}
