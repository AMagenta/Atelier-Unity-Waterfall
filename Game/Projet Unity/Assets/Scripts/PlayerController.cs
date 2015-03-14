/* using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private bool canJump = true;
	private bool jumping = false;

	// Use this for initialization
	void Start () {

	}

	
	// Update is called once per frame
	void Update () {
	
	}

	// Modifs physiques
	void FixedUpdate() {
		Vector3 direction = new Vector3();
		direction += Input.GetAxis ("Horizontal") * Camera.main.transform.right;
		direction += Input.GetAxis ("Vertical") * Camera.main.transform.forward;
		direction.y = 0;

		Vector3 newVelocity = direction * 10;
		newVelocity.y = rigidbody.velocity.y;

		rigidbody.velocity = direction * 10;
		transform.LookAt(transform.position + direction);
		rigidbody.angularVelocity = new Vector3();

		if (Input.GetButtonDown ("Jump")) && canJump){
			rigidbody.AddForce (Vector3.up * 10, ForceMode.Impulse);
			canJump = false;
			jumping = true;
		}
	}

	void OnCollisionEnter(Collision col) {

		if (col.contacts[0].normal.y > 0.3f)
			canJump = true;
		}

}
*/
