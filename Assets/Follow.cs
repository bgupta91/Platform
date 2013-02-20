using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	// Use this for initialization
	public GameObject suspect;
	void Start () {
	
		//suspect = GameObject.find("");
	}
	
	// Update is called once per frame
	void Update () {
	
		var position = transform.position;
		float x = suspect.transform.position.x;
		if(position.x != x)
			position.x = x;
		transform.position = position;
	}
}
