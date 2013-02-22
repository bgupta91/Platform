using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	// Use this for initialization
	public GameObject suspect;
	
	void Start () {
	
		suspect = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if ( suspect ) {
			var position = transform.position;
			float x = suspect.transform.position.x;
			if(position.x != x)
				position.x = x;
			transform.position = position;
		} else { 
			suspect = GameObject.FindWithTag("Player");
		}
	}
	
	void Destroy() {
		GetComponent<AudioSource>().Stop();
		GetComponent<AudioSource>().Play();
		//Destroy(GetComponent<AudioSource>());
		//gameObject.AddComponent("Audio Source");
	}
}
