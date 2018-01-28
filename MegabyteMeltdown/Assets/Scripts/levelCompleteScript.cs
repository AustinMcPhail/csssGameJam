using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelCompleteScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            print(this.gameObject.name);
            SceneManager.LoadScene(this.gameObject.name);
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
