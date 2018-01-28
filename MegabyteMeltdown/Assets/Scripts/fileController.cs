using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fileController : MonoBehaviour {

    float maxUpAndDown = 0.005f;
    float speed = 100.0f;
    float angle = 0.0f;
    float toDegrees = Mathf.PI / 180;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        angle += speed * Time.deltaTime;
        if (angle > 360) angle -= 360;
        transform.Translate(new Vector3(0.0f, maxUpAndDown * Mathf.Sin(angle * toDegrees), 0.0f));
    }
}

