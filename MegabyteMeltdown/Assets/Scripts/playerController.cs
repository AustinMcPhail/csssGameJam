using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class playerController : MonoBehaviour {
    public float speed = 5.0f;
    public float jumpPower = 5.0f;
    public bool isGrounded = false;

    AudioSource audio;
    Animator anim;

    // Use this for initialization
    void Start () {
        anim = gameObject.GetComponent<Animator>();
        anim.SetBool("isGrounded", true);
        anim.SetBool("isMoving", false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(new Vector2(-speed * Time.deltaTime, 0.0f));
            anim.SetBool("isMoving", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("isMoving", false);
        }

        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(new Vector2(speed * Time.deltaTime, 0.0f));
            anim.SetBool("isMoving", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("isMoving", false);
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded == true) {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, jumpPower), ForceMode2D.Impulse);
            isGrounded = false;
            anim.SetBool("isGrounded", false);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            isGrounded = true;
            anim.SetBool("isGrounded", true);
        }

        if(coll.gameObject.tag == "Firewall")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
	