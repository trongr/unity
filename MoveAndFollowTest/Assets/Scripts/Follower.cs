using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour {

	public Transform player;
	public float speed = 7f;

	// Update is called once per frame
	void Update() {
		Vector3 displacementFromPlayer = player.position - transform.position;
		Vector3 directionToPlayer = displacementFromPlayer.normalized;
		Vector3 velocity = directionToPlayer * speed;
		Vector3 displacement = velocity * Time.deltaTime;
		if (displacementFromPlayer.magnitude > 2) {
			transform.Translate(displacement);
		}
	}
}