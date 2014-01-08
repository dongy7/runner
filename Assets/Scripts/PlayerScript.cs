using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	// allow user to edit this from the inspector
	public Vector2 speed = new Vector2(3, 3);
	Vector2 movement;

	void Update () {
		this.movement = Vector2.zero;
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.movement.x += 1f;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.movement.x -= 1f;
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			this.movement.y = 1f;
		}

		this.movement.x *= this.speed.x;
		this.movement.y *= this.speed.y;
	}

	void FixedUpdate() {
		rigidbody2D.velocity = this.movement;
	}
}
