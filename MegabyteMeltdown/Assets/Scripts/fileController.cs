using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fileController : MonoBehaviour {

    float maxUpAndDown = 0.005f;
    float speed = 100.0f;
    float angle = 0.0f;
    float toDegrees = Mathf.PI / 180;

    public bool paused;
    public bool collected;

    public int scoreValue;
    private GameController gameController;

    // Use this for initialization
    void Start () {
        paused = false;
        collected = false;

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");

        if (gameControllerObject != null)
        {
            /*
			 * ... then we will set our Game Controller reference to the Game Controller component on the Game Controller object.
			 * We do this by searching the Game Controller object and getting the component on it, with GetComponent searching 
			 * for the type of GameController.
			*/
            Debug.Log("GameController Found!!!!!");
            gameController = gameControllerObject.GetComponent<GameController>();
        }

        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player" && !collected)
        {
            collected = true;
            gameController.AddScore(scoreValue);
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }


        if (paused)
        {
            //do nothing
        }
        else if (!paused)
        {
            angle += speed * Time.deltaTime;
            if (angle > 360) angle -= 360;
            transform.Translate(new Vector3(0.0f, maxUpAndDown * Mathf.Sin(angle * toDegrees), 0.0f));
        }
        
    }
}

