using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
	
	
	public GameObject playerPrefab;
	private GameObject player;
	
	public GameObject blockPrefab;
	private GameObject block;
	
	private GameObject camera;
	
	//private Vector3 levelBegin = new Vector3 (-20,0,0);
	
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 100; i++) {
			block = Instantiate(blockPrefab, new Vector3(10 + (i * 20),.5f,0), Quaternion.identity) as GameObject;
			if (i % 2 == 0) {
				block = Instantiate(blockPrefab, new Vector3(20 + (i * 13),.5f,0), Quaternion.identity) as GameObject;
			}
		}
		player = Instantiate(playerPrefab, new Vector3(0,2,0), Quaternion.identity) as GameObject;
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void restart() {
		camera = GameObject.FindWithTag("MainCamera");
		camera.SendMessage("Destroy");
		player = Instantiate(playerPrefab, new Vector3(0,2,0), Quaternion.identity) as GameObject;
	}
}
