﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		// Destroy everything that leaves the trigger
		Destroy(GameObject.FindGameObjectWithTag ("Enemy").gameObject);
		Debug.Log ("ENEMMIGO ELIMINADO!!!!!");

		Object.DestroyObject (GameObject.FindGameObjectWithTag ("Enemy").gameObject);
		Debug.Log ("ENEMMIGO ELIMINADO!!!!!");
	}	
	void OnTriggerEnter2D(Collider2D other)
	// void OnTriggerEnter2D(Collider2D other)
	{
		// Destroy everything that leaves the trigger

		Destroy(GameObject.FindGameObjectWithTag ("Enemy").gameObject);
		Debug.Log ("ENEMMIGO ELIMINADO!!!!!");

		Object.DestroyObject (GameObject.FindGameObjectWithTag ("Enemy").gameObject);
		Debug.Log ("ENEMMIGO ELIMINADO!!!!!");
	}	



}
