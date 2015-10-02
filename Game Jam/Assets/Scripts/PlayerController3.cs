using UnityEngine;
using System.Collections;

public class PlayerController3 : MonoBehaviour {

	public Rigidbody rb;
	public Animator animator;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		animator.SetBool("isWalking", false);
	}

	// Update is called once per frame
	void Update () {
		animator.SetBool("isWalking", false);
		
	
	}
}









