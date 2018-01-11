using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	/*public int speed = 5;
	void Update () {
		// Only if there are touches
		if (Input.touches.Length > 0)
		{
			if (Input.touches[0].phase == TouchPhase.Moved)
			{
				var x = Input.touches[0].deltaPosition.x * speed * Time.deltaTime;
				var y = Input.touches[0].deltaPosition.y * speed * Time.deltaTime;

				transform.Translate(new Vector3(x, y, 0));
			}
		}
	}*/
	/*Renderer[] renderers;
	//var cam = Camera.main;

	//var viewportPosition = cam.WorldToViewportPoint(transform.position);

	void Start()
	{
		renderers = GetComponentsInChildren<Renderer>();
	}

	bool CheckRenderers()
	{
		foreach(Renderer renderer in renderers)
		{
			// If at least one render is visible, return true
			if(renderer.isVisible)
			{
				return true;
			}
		}

		// Otherwise, the object is invisible
		return false;
	}

	bool isWrappingX = false;
	bool isWrappingY = false;
	void ScreenWrap()
	{
		var isVisible = CheckRenderers();

		if(isVisible)
		{
			isWrappingX = false;
			isWrappingY = false;
			return;
		}

		if(isWrappingX && isWrappingY) {
			return;
		}

		var cam = Camera.main;
		var viewportPosition = cam.WorldToViewportPoint(transform.position);
		var newPosition = transform.position;

		if (!isWrappingX && (viewportPosition.x > 1 || viewportPosition.x < 0))
		{
			newPosition.x = -newPosition.x;

			isWrappingX = true;
		}

		if (!isWrappingY && (viewportPosition.y > 1 || viewportPosition.y < 0))
		{
			newPosition.y = -newPosition.y;

			isWrappingY = true;
		}

		transform.position = newPosition;
	}*/

	float rotSpeed = 20;

	void OnMouseDrag()
	{
		float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
		//float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

		transform.RotateAround(Vector3.up, -rotX);
		//transform.RotateAround(Vector3.right, rotY);
	}
}