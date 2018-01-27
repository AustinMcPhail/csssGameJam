using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}
	
public class PlayerController : MonoBehaviour
{
	public float speed = 5.0f;
	public float jumpPower = 5.0f;
	public bool isGrounded = false;
	public Rigidbody rb;
	public AudioSource audio;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		audio = GetComponent<AudioSource> ();
	}
	// For player movement
	public float speed2;
	public float tilt;
	public Boundary boundary;

	// For Shooting
	public GameObject projectile;
	public float fireDelta = 0.5f;
	private float nextFire = 0.5f;
	private GameObject newProjectile;
	private float myTime = 0.0f;
	public Transform shotSpawn;


	void Update()
	{
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

		myTime = myTime + Time.deltaTime;

		if(Input.GetButton("Fire1") && myTime > nextFire)
		{
			nextFire = myTime + fireDelta;
			//newProjectile = 
			Instantiate (projectile, shotSpawn.position, shotSpawn.rotation); // as GameObject;
			// audio
			audio.Play ();

			nextFire = nextFire - myTime;
			myTime = 0.0f;
		}

	}



	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "ground")
		{
			isGrounded = true;
		}
	}

}