using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Update is called once per clock
	void FixedUpdate () {
		Rigidbody2D body = GetComponent<Rigidbody2D> ();

		if (Input.GetKey ("w") || Input.GetKey ("up")) {
			body.AddForce (new Vector2(0, 2));
		}
		if (Input.GetKey ("a") || Input.GetKey ("left")) {
			body.AddForce (new Vector2(-2, 0));
		}
		if (Input.GetKey ("s") || Input.GetKey ("down")) {
			body.AddForce (new Vector2(0, -2));
		}
		if (Input.GetKey ("d") || Input.GetKey ("right")) {
			body.AddForce (new Vector2(2, 0));
		}
	}
}
