using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour {


	public DirectionEnum direction = DirectionEnum.North;
	
	void Start() {
		UpdateDirection();
	}

	public void UpdateDirection() {
		Vector3 rotation = transform.rotation.eulerAngles;
		if (ApproximatelyEquals(rotation.y, 0, 0.01)) {
			direction = DirectionEnum.North;
		} else if (ApproximatelyEquals(rotation.y, 90, 0.01)) {
			direction = DirectionEnum.East;
		}  else if (ApproximatelyEquals(rotation.y, 180, 0.01)) {
			direction = DirectionEnum.South;
		} else if (ApproximatelyEquals(rotation.y, 270, 0.01)) {
			direction = DirectionEnum.West;
		}
	}


	static bool ApproximatelyEquals(double value1, double value2, double acceptableDifference)
	{
    	return Math.Abs(value1 - value2) <= acceptableDifference; 
	}
}
