using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    public float speed = 5.0f;
    public float jumpPower = 5.0f;
    public bool isGrounded = false;
	// Use this for initialization
	void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector2(-speed * Time.deltaTime, 0.0f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector2(speed * Time.deltaTime, 0.0f));
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded == true)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, jumpPower), ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            isGrounded = true;

        }
    }
    
}
