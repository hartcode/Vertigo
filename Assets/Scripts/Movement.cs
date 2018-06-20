using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	Vector3 direction;
	Quaternion updatedRotation;

	// Update is called once per frame
	void FixedUpdate () {
		float vertical = 0;
		float horizontal = 0;
		if (Input.GetAxis("Vertical") > 0) {
			vertical = 1;
			direction = new Vector3 (horizontal, 0, vertical);
			Move ();
		} else if (Input.GetAxis("Vertical") < 0) {
			vertical = -1;
			direction = new Vector3 (horizontal, 0, vertical);
			Move ();
		}
		if (Input.GetAxis("Horizontal") < 0) {
			horizontal = -1;
			direction = new Vector3 (horizontal, 0, vertical);
			Move ();
		} else if (Input.GetAxis("Horizontal") > 0) {
			horizontal = 1;
			direction = new Vector3 (horizontal, 0, vertical);
			Move ();
		}


	}

	protected void Move ()
	{
		Vector3 updatedPosition = transform.position + direction * Time.deltaTime;
		transform.position = updatedPosition;
		transform.rotation = updatedRotation;
	}
}
