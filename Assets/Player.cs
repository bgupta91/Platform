using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private double delay = 0;
	//bool duck;
	// Use this for initialization
	void Start () {
		//duck = false;
	}
	
	void Update () {
		
		/*if(Input.GetKeyDown("down")){
			this.transform.Rotate(0, 0, 90);	
			//later this will move the thing while its turned
			//Vector3 constant = new Vector3(0 , 0, 0);
		}*/
		if(Input.GetKey(KeyCode.UpArrow) && delay <= 0){
			rigidbody.AddForce(2 * Vector3.up * Time.deltaTime);
			delay = 50 * Time.deltaTime;
		}
			

		/*if(Input.GetKeyDown("up")/* && and the paddle is in contact with the ground){ //and the object is touching the ground
			Vector3 movement = new Vector3(0,40,0);
			this.transform.Translate(movement * Time.deltaTime);
			this.transform.Rotate(Vector3.zero);
			
		}*/
		
		delay = delay - Time.deltaTime;	
		
	}

	
	
	/*void OnCollisionEnter(Collision collision) {
        foreach (ContactPoint contact in collision.contacts) {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
       // if (collision.relativeVelocity.magnitude > 2)
         //   audio.Play();
        
    }
	*/
}
