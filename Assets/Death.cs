using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {
	
	private GameObject GM;
	private GameMaster gm;
	
	// Use this for initialization
	void Start () {
		GM = GameObject.FindWithTag("GM");
		gm = GM.GetComponent<GameMaster>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		gm.SendMessage("restart");
	}
}
