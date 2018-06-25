using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour {

	float lastTurnTime = 0;
	public float turnTimeWait = 0.3f;
	

	void FixedUpdate () {
		if (Time.time - lastTurnTime > turnTimeWait)
		{
        	if (Input.GetAxis("Horizontal") > 0) {
		     	doTurn(90);
			} else if (Input.GetAxis("Horizontal") < 0) {
            	doTurn(-90);
			}
        }
	}

	void doTurn(float yRotation) {
		transform.Rotate(0, yRotation, 0);
		lastTurnTime = Time.time;
		SendMessage("UpdateDirection");
	}

	
}
