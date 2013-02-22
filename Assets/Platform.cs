using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 constant = new Vector3(-7, 0, 0);
		transform.Translate(constant * Time.deltaTime);
	}
}
