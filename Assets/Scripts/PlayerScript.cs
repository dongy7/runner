using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	// allow user to edit this from the inspector
	public Vector2 speed = new Vector2(3, 3);
	Vector2 movement;

	void Update () {
		var inputX = Input.GetAxis ("Horizontal");
		var inputY = Input.GetAxis ("Vertical");

		this.movement = new Vector2 (
			this.speed.x * inputX,
			this.speed.y * inputY);
	}

	void FixedUpdate() {
		rigidbody2D.velocity = this.movement;
	}
}
