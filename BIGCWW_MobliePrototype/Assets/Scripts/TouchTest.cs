using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchTest : MonoBehaviour 
{
	// Update is called once per frame
	public float speed = 0.1F;
	public GameObject player; 

	void Update() 
	{
		////////////////////////////////////////////////////
		//Check that player position is within the screen//
		//////////////////////////////////////////////////
		if (player.transform.position.x >= -2.30f && player.transform.position.x <= 2.30f) 
		{
			//////////////////////////////////////////
			//Touch movement with Y-axis restricted//
			////////////////////////////////////////
			if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) 
			{
				Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
				transform.Translate (touchDeltaPosition.x * speed, 0 * speed, 0);
			}
			//////////////////////////////////////////////////
			//Guarantees that the player wont go off screen//
			////////////////////////////////////////////////
			Vector2 p = player.transform.position;
			player.transform.position = new Vector2( Mathf.Clamp( p.x, -2.3f, 2.3f ), p.y);
		}
	}
}
