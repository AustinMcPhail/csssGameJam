using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireWallController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector2(0.05f, 0.0f));
	}
}
