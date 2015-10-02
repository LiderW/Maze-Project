using UnityEngine;
using System.Collections;

public class PlayerController2 : MonoBehaviour {

	public Rigidbody rb;
	public Animator animator;
	public float speed = 1;
	public float angularSpeed = 30;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	public float currentAngularMultiplyer;
	public float currentVelocityMultiplyer;
	
	// Update is called once per frame
	void FixedUpdate () {


		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;
		currentAngularMultiplyer = Input.GetKey(KeyCode.RightArrow)? 1: (Input.GetKey (KeyCode.LeftArrow)? -1: 0);
		currentVelocityMultiplyer = Input.GetKey(KeyCode.UpArrow)? 1: (Input.GetKey (KeyCode.DownArrow)? -1: 0);
		rb.angularVelocity = transform.up * currentAngularMultiplyer * angularSpeed;
		rb.velocity = transform.forward * currentVelocityMultiplyer * speed + Physics.gravity * Time.fixedDeltaTime;

		if(currentAngularMultiplyer == 0 && currentVelocityMultiplyer == 0){
			animator.SetBool("isWalking", false);
		} else {
			animator.SetBool("isWalking", true);
		}
	
	}
}









