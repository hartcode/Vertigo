using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Direction direction;
    Map map = new Map();

    void Start()
    {
        if (direction == null) {
            direction = GetComponent<Direction>();
        }
    }
    void FixedUpdate()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        if (Time.time - lastMovementTime > movementTimeWait)
		{
        	if (Input.GetAxis("Vertical") > 0) {
		     	doMove(1);
			} else if (Input.GetAxis("Vertical") < 0) {
            	doMove(-1);
			}
        }
    }

    float lastMovementTime = 0;

	public float movementTimeWait = 0.3f;
	
	void doMove(float forward) {
        
        float xDelta = 0;
        float zDelta = 0;
        switch(direction.direction)
        {
            case DirectionEnum.North:
                zDelta = forward;
            break;
                case DirectionEnum.East:
                xDelta = forward;
            break;
                case DirectionEnum.South:
                zDelta = -forward;
            break;
                case DirectionEnum.West:
                xDelta = -forward;
            break;
        }
        Vector3 newPosition = transform.position + new Vector3(xDelta, 0, zDelta);
        if (newPosition.z  > 0 && newPosition.x > 0 && newPosition.z < 31 && newPosition.x < 31) {
            if (map.MovementMap[(int)newPosition.z, (int)newPosition.x]) {
                transform.position = newPosition;
		        lastMovementTime = Time.time;
            }
        }
	}
}
