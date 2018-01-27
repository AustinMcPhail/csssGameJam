using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    public float speed = 10;
    public float jumpPower = 5;
    public bool isGrounded = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    public void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector2(-speed * Time.deltaTime, 0.0f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector2(speed * Time.deltaTime, 0.0f));
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, 1.0f), ForceMode2D.Impulse);
        }
    }
}
