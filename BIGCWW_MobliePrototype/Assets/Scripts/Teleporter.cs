using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour
{
	//public AudioSource sparkClip;

	public Transform exit;
	static Transform last;

	void OnTriggerEnter ( Collider other )
	{
		if ( exit == last )
			return;
		TeleportToExit( other );
	}
	void OnTriggerExit ( )
	{
		if ( exit == last )
			last = null;
	}
	void TeleportToExit ( Collider other )
	{
		last = transform;
		//sparkClip.Play ();
		other.transform.position = exit.transform.position;
	}
}
