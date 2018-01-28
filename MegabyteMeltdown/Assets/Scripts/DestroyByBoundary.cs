using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour 
{
	void OnTriggerExit(Collider other)
	{
		// Destroy everything that leaves the trigger
		Debug.Log ("ENEMY DESTROYED!!!!!");
		Destroy(other.gameObject);
		Debug.Log ("ENEMY DESTROYED!!!!!");
	}	
}
