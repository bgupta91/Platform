using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	int speed = 15;
	private Vector3 playerForward = new Vector3(4,0,0);
	private Vector3 playerMov = new Vector3(0,0,0);
	
	void Start () {
		//duck = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		//Vector3 constant = new Vector3(2, 0, 0);
		rigidbody.AddForce(1, 0, 0);
		
		if(Input.GetKeyDown("down")){
			this.transform.Rotate(0, 0, 90);	
			//later this will move the thing while its turned
			//Vector3 constant = new Vector3(0 , 0, 0);
		}
		if(Input.GetKeyUp("down")){
			this.transform.Rotate(0, 0, -90);
			//print ("down was released");
		}
			//constant = temp;

		if(Input.GetKeyDown("up")/* && and the paddle is in contact with the ground*/){ //and the object is touching the ground
			Vector3 movement = new Vector3(0,40,0);
			this.transform.Translate(movement * Time.deltaTime);
			this.transform.Rotate(Vector3.zero);
			
		}
		//Vector3 constant = new Vector3(2, 0, 0);
		
		//playerMov.Set(4, Input.GetAxis("Vertical") * speed,0);
		//transform.Translate(playerMov * Time.deltaTime);
		//transform.Translate(playerForward * Time.deltaTime);
		
	}

	
	
	void OnCollisionEnter(Collision collision) {
        foreach (ContactPoint contact in collision.contacts) {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        //if (collision.relativeVelocity.magnitude > 2)
            //audio.Play();
        
    }
	
}
