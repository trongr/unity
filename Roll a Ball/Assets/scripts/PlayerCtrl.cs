using UnityEngine;
using System.Collections;

public class PlayerCtrl : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate() {
        float moveHor = Input.GetAxis("Horizontal");
        float moveVer = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHor, 0, moveVer);
        rb.AddForce(movement * speed);
    }
}
