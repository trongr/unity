using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 6;
	Vector3 velocity;
	Rigidbody playerrb;
	int coins;

	// Use this for initialization
	void Start() {
		playerrb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update() {
		Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		Vector3 direction = input.normalized;
		velocity = direction * speed;
	}

	// Use this for physics updates.
	void FixedUpdate() {
		playerrb.position += velocity * Time.fixedDeltaTime;
	}

	void OnTriggerEnter(Collider col) {
		if (col.tag == "Coin") {
			Destroy(col.gameObject);
			coins++;
			print("Coins: " + coins);
		}
	}
}