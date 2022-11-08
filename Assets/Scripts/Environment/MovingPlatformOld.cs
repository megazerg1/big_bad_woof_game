using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformOld : MonoBehaviour {
	
	float dirX, moveSpeed = 2;
	bool moveRight = true;

	// Update is called once per frame
	void Update () {
		if (transform.position.x > 4)
			moveRight = false;
		if (transform.position.x < -2)
			moveRight = true;

		if (moveRight)
			transform.position = new Vector4(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
		else
			transform.position = new Vector4(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
	}
}
