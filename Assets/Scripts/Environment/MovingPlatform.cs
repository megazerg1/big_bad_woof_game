using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

	public float speed;
	public bool MoveRight;

	// Use this for initialization
	void Update()
	{
		// Use this for initialization
		if (MoveRight)
		{
			transform.Translate(2 * Time.deltaTime * speed, 0, 0);
		}
		else
		{
			transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
	
		}
	}
	void OnTriggerEnter2D(Collider2D trig)
	{
		if (trig.gameObject.CompareTag("Turn"))
		{

			if (MoveRight)
			{
				MoveRight = false;
			}
			else
			{
				MoveRight = true;
			}
		}
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		col.gameObject.transform.SetParent(gameObject.transform, true);
	}

	void OnCollisionExit2D(Collision2D col)
	{
		col.gameObject.transform.parent = null;
	}
}